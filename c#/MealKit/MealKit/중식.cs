using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealKit
{
    public partial class 중식 : Form
    {
        public 중식()
        {
            InitializeComponent();
            this.Load += 중식_Load;
        }

        private void 중식_Load(object sender, EventArgs e)
        {
            // 폼이 로드될 때 양식에 해당하는 상품 로드
            DataManager.KitLoad();
            // UC_CartItem의 QuantityChanged 이벤트 핸들링
            foreach (UC_CartItem cartItem in panel5.Controls.OfType<UC_CartItem>())
            {
                cartItem.RemoveFromPanelEvent += UC_CartItem_RemoveFromPanel;
                cartItem.QuantityChanged += UC_CartItem_QuantityChanged;
            }
            // UC_CartItem의 TotalPriceChangedInForm 이벤트 핸들링
            foreach (UC_CartItem cartItem in panel5.Controls.OfType<UC_CartItem>())
            {
                cartItem.TotalPriceChangedInForm += UC_CartItem_TotalPriceChangedInForm;
            }
            // panel1에 UC_Item 추가 및 클릭 이벤트 연결
            AddUCItemsToPanel();
            UpdateTotalCartPrice();
        }
        private void UC_CartItem_RemoveFromPanel(object sender, EventArgs e)
        {
            // UC_CartItem이 제거될 때 총 가격을 업데이트
            UpdateTotalCartPrice();
        }

        private void UC_CartItem_QuantityChanged(object sender, EventArgs e)
        {
            // UC_CartItem의 수량이 변경될 때 총 가격을 업데이트
            UpdateTotalCartPrice();
        }

        private void UpdateTotalCartPrice()
        {
            // panel5에 있는 모든 UC_CartItem의 총 가격을 확인하고 총합을 계산
            decimal totalCartPrice = CalculateTotalCartPrice();

            // panel6의 label2에 총합을 표시
            label2.Text = $"{totalCartPrice.ToString()}원";
        }

        private decimal CalculateTotalCartPrice()
        {
            decimal totalCartPrice = 0;

            foreach (UC_CartItem cartItem in panel5.Controls.OfType<UC_CartItem>())
            {
                decimal itemTotalPrice = decimal.Parse(new string(cartItem.itemPrice.Where(c => Char.IsDigit(c) || c == '.').ToArray())) * cartItem.Quantity;
                totalCartPrice += itemTotalPrice;
            }

            return totalCartPrice;
        }
        // 중식 폼 내부에서 총 가격을 저장할 변수
        private decimal totalPriceInPanel5;
        // 추가: UC_CartItem의 총 가격이 변경될 때 호출되는 이벤트 핸들러
        private void UC_CartItem_TotalPriceChangedInForm(object sender, decimal totalPrice)
        {
            // UC_CartItem의 총 가격을 더하여 중식 폼 내부 변수에 저장
            totalPriceInPanel5 += totalPrice;

            // 중식 폼의 panel6의 label2에 총 가격 업데이트
            label2.Text = $"총 금액 : {totalPriceInPanel5}원";
        }
        // 추가: UC_CartItem의 총 가격이 변경될 때 업데이트하는 메서드
        private void CalculateTotalPriceInPanel6(decimal totalPrice)
        {
            // panel6의 label2를 업데이트
            label2.Text = $"총 금액 : {totalPrice}원";
        }

 
        // UC_CartItem의 TotalPriceChanged 이벤트 핸들러
        private void UC_CartItem_TotalPriceChanged(object sender, EventArgs e)
        {
            CalculateTotalPriceInPanel5();
        }

        // panel5에 있는 모든 UC_CartItem의 총 가격을 계산하여 label2_Panel5에 표시
        private void CalculateTotalPriceInPanel5()
        {
            decimal totalPriceInPanel5 = 0;

            foreach (UC_CartItem cartItem in panel5.Controls.OfType<UC_CartItem>())
            {
                totalPriceInPanel5 += cartItem.Quantity * decimal.Parse(new string(cartItem.itemPrice.Where(c => Char.IsDigit(c) || c == '.').ToArray()));
            }

            label2.Text = $"총 금액 : {totalPriceInPanel5}원";
        }

        private void AddUCItemsToPanel()
        {
            int itemCount = 0; // 추가된 UC_Item 개수를 세기 위한 변수
            int itemsPerRow = 3; // 한 행에 표시할 아이템 개수
            int itemWidth = 150; // 각 UC_Item의 폭
            int itemHeight = 200; // 각 UC_Item의 높이
            int horizontalSpacing = 50; // 아이템 간 가로 간격
            int verticalSpacing = 30; // 아이템 간 세로 간격

            int startX = 50; // 시작 X 좌표
            int startY = 50; // 시작 Y 좌표

            foreach (Product product in DataManager.products)
            {
                if (product.item_kind.ToLower() == "중식")
                {
                    UC_Item ucItem = new UC_Item
                    {
                        itemName = product.item_name,
                        itemPrice = product.item_price.ToString(),
                    };

                    // 이미지를 설정
                    string imageName = product.item_name;
                    var image = (Image)Properties.Resources.ResourceManager.GetObject(imageName);

                    if (image != null)
                    {
                        ucItem.itemImage = image;

                        // 아이템의 위치 동적 계산
                        int row = itemCount / itemsPerRow;
                        int col = itemCount % itemsPerRow;

                        int x = startX + col * (itemWidth + horizontalSpacing);
                        int y = startY + row * (itemHeight + verticalSpacing);

                        ucItem.Location = new Point(x, y);

                        // 클릭 이벤트 핸들러 등록
                        ucItem.ItemClicked += (s, e) => UC_Item_Click_중식(ucItem);

                        panel1.Controls.Add(ucItem);
                        itemCount++; // UC_Item 추가될 때마다 개수 증가                       

                        // 중식 폼에 새로운 클릭 이벤트 핸들러 등록
                        ucItem.ItemClicked += (s, e) => CalculateTotalPriceInPanel5();
                    }
                    else
                    {
                        Console.WriteLine($"Image '{imageName}' not found in Resources.");
                    }
                }

            }

            Console.WriteLine($"Added {itemCount} UC_Items to panel1."); // 추가된 개수 출력
        }

        private void UC_Item_Click_중식(UC_Item ucItem)
        {
            try
            {
                // 중복된 상품이 이미 있는지 확인
                UC_CartItem existingCartItem = FindExistingCartItem(ucItem.itemName);

                if (existingCartItem != null)
                {
                    // 이미 있는 상품이라면 수량을 증가시킴
                    existingCartItem.Quantity++;
                }
                else
                {
                    // UC_CartItem 객체를 생성하고 초기화
                    UC_CartItem cartItem = new UC_CartItem();
                    cartItem.itemImage = ucItem.itemImage;
                    cartItem.itemName = ucItem.itemName;
                    cartItem.itemPrice = $"￦{ucItem.itemPrice}"; 
                    cartItem.Quantity = 1; // 초기 수량은 1

                    // 위치 계산
                    if (panel5.Controls.Count > 0)
                    {
                        UC_CartItem lastCartItem = panel5.Controls[panel5.Controls.Count - 1] as UC_CartItem;
                        if (lastCartItem != null)
                        {
                            int yOffset = lastCartItem.Bottom + 10;
                            cartItem.Location = new Point(20, yOffset);
                        }
                        else
                        {
                            cartItem.Location = new Point(20, 30);
                        }
                    }
                    else
                    {
                        cartItem.Location = new Point(20, 30);
                    }

                    // panel5에 UC_CartItem 컨트롤 추가
                    panel5.Controls.Add(cartItem);
                    // UC_CartItem 추가 시에도 총 가격을 계산
                    CalculateTotalPriceInPanel5();
                }
            }
            catch (Exception ex)
            {
                // 오류 발생 시 메시지 박스 표시
                MessageBox.Show($"오류: {ex.Message}");
            }
        }



        // 중복된 상품이 있는지 확인하는 메서드
        private UC_CartItem FindExistingCartItem(string itemName)
        {
            foreach (Control control in panel5.Controls)
            {
                if (control is UC_CartItem cartItem && cartItem.itemName == itemName)
                {
                    return cartItem;
                }
            }
            return null;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            메인화면 frm1 = new 메인화면();
            frm1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            장바구니 frm2 = new 장바구니();
            frm2.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            회원정보 frm3 = new 회원정보();
            frm3.Show();
        }
    }
}
