import csv  #csv 파일 읽는 라이브러리 호출

f = open('mydata.csv','r')  #open 함수를 통해 읽어들인 파일에 대한 내용

rdr = csv.reader(f) #파일 데이터 읽음

mydata = [] #리스트 선언

isStart = True

for line in rdr:    #rdr에 있는 걸 한줄씩
    if isStart:
        isStart=False
        pass
    else:
        mydata.append(line)
f.close()
for item in mydata:
    print(('상호명:%s, 전화번호:%s, 대표메뉴:%s')%(item[1],item[3],item[4]))

for item in mydata:
    if item[1] == '상호명':
        pass
    else:
        print(('상호명:%s, 전화번호:%s, 대표메뉴:%s')%(item[1],item[3],item[4]))