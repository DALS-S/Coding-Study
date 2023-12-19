import json
import pymysql
import urllib.request
import matplotlib.pyplot as pl
from matplotlib import  font_manager

font_path = "C:\\Windows\\Fonts/H2GSRB.TTF"
font_prop = font_manager.FontProperties(fname=font_path)
pl.rcParams['font.family']=font_prop.get_name()

myurl = 'https://api.odcloud.kr/api/3074463/v1/uddi:cbfa511d-490e-4132-9064-ce91185fced2?page=1&perPage=1000000&serviceKey=MfKZl8f8O7MhFaujSYXlnStV6EXfUl3j66hRIC7INogJmsfjOJUVV21KPi4%2BOhZg3CGujV4CwcuTn6su2x9k8w%3D%3D'

response = urllib.request.urlopen(myurl)
response = response.read().decode('utf8')

data = json.loads(response)
json_arr = data['data']

conn = pymysql.connect(
        host='localhost',
        user='root',
        password='1234',
        db='apidb',
        charset='utf8'
    )

sql = ('insert into crime(범죄대분류, 범죄중분류, 고속도로, 공사장_광산, 공장, 공중화장실, 공지, 구금장소, 금융기관, 기타, '
       '기타교통수단내, 노상, 단독주택, 대형할인매장, 백화점, 부대, 사무실, 산야, 상점, 숙박업소_목욕탕, '
       '슈퍼마켓, 시장_노점, 아파트_연립다세대, 역_대합실, 유원지, 유흥접객업소, 의료기관, 종교기관, 주차장, 지하철, '
       '창고, 편의점, 피씨방, 학교, 해상, 흥행장) ')
sql = sql + ("values('%s', '%s', '%s', '%s', '%s','%s', '%s', '%s', '%s', '%s',"
             "'%s', '%s', '%s', '%s', '%s','%s', '%s', '%s', '%s', '%s',"
             "'%s', '%s', '%s', '%s', '%s','%s', '%s', '%s', '%s', '%s',"
             "'%s', '%s', '%s', '%s', '%s', '%s')")

cur = conn.cursor()

for item in json_arr:
    cur.execute(sql % (item['범죄대분류'],item['범죄중분류'],item['고속도로'],item['공사장_광산'],item['공장'],item['공중화장실'],item['공지'],item['구금장소'],item['금융기관'],item['기타'],
                       item['기타교통수단내'],item['노상'],item['단독주택'],item['대형할인매장'],item['백화점'],item['부대'],item['사무실'],item['산야'],item['상점'],item['숙박업소_목욕탕'],
                       item['슈퍼마켓'],item['시장_노점'],item['아파트_연립다세대'],item['역_대합실'],item['유원지'],item['유흥접객업소'],item['의료기관'],item['종교기관'],item['주차장'],item['지하철'],
                       item['창고'],item['편의점'],item['피씨방'],item['학교'],item['해상'],item['흥행장']))

conn.commit()

sql1 = ('select distinct 범죄대분류 from crime')
cur.execute(sql1)
crimeKind = cur.fetchall()

sql2 = ('select 범죄대분류, count(*) from crime group by 범죄대분류')
cur.execute(sql2)
crimeCnt = cur.fetchall()

conn.close()

pl.bar([crimeKind[0] for crimeKind in crimeKind], [count[1] for count in crimeCnt])
pl.xlabel('범죄')
pl.ylabel('범죄건수(건)')
pl.title('특정 범죄 현황')
pl.show()
