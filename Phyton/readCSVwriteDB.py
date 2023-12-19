import csv  #csv 파일 읽는 라이브러리 호출
import pymysql

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

sql = 'insert into apitable(name, hp, menu) '
sql = sql + "values('%s', '%s', '%s')"

for item in mydata:
    conn = pymysql.connect(
        host='localhost',
        user='root',
        password='1234',
        db='apidb',
        charset='utf8'
    )

    # with : db 연결후 다되면 자동으로 연결 끊어줌
    with conn:
        with conn.cursor() as cur: # db 안에 실제 명령 수행
            cur.execute(sql % (item[1],item[3],item[4]))
            conn.commit()
