namespace MealKit
{
    partial class UC_PayMent
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.uC_Item1 = new MealKit.UC_Item();
            this.SuspendLayout();
            // 
            // uC_Item1
            // 
            this.uC_Item1.BackColor = System.Drawing.Color.White;
            this.uC_Item1.Font = new System.Drawing.Font("경기천년제목 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uC_Item1.itemImage = null;
            this.uC_Item1.itemName = "item Name";
            this.uC_Item1.itemPrice = "\\0";
            this.uC_Item1.Location = new System.Drawing.Point(0, 0);
            this.uC_Item1.Name = "uC_Item1";
            this.uC_Item1.Size = new System.Drawing.Size(175, 174);
            this.uC_Item1.TabIndex = 0;
            // 
            // UC_PayMent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uC_Item1);
            this.Name = "UC_PayMent";
            this.Size = new System.Drawing.Size(599, 174);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Item uC_Item1;
    }
}
