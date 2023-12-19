import json
import pymysql
import urllib.request
import matplotlib.pyplot as pl
from matplotlib import  font_manager

font_path = "C:\\Windows\\Fonts/H2GSRB.TTF"
font_prop = font_manager.FontProperties(fname=font_path)
pl.rcParams['font.family']=font_prop.get_name()

myurl = 'https://api.odcloud.kr/api/15125155/v1/uddi:a7ac6ed5-a0e1-41e3-a33b-9feee64e76cc?page=1&perPage=10000&serviceKey=MfKZl8f8O7MhFaujSYXlnStV6EXfUl3j66hRIC7INogJmsfjOJUVV21KPi4%2BOhZg3CGujV4CwcuTn6su2x9k8w%3D%3D'

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

sql = 'insert into disease(diseaseName, sigungu, sido, count, year) '
sql = sql + "values('%s', '%s', '%s', '%s', '%s')"

cur = conn.cursor()

for item in json_arr:
    cur.execute(sql % (item['질환'],item['시군구'],item['시도'],item['진료건수(건)'],item['진료년월']))

conn.commit()

sql1 = 'select distinct diseaseName from disease'
cur.execute(sql1)
diseaseName = cur.fetchall()

sql2 = 'select diseaseName, count(*) from disease group by diseaseName'
cur.execute(sql2)
diseaseCnt = cur.fetchall()

conn.close()

pl.bar([diseaseName[0] for diseaseName in diseaseName], [count[1] for count in diseaseCnt])
pl.xlabel('질환')
pl.ylabel('진료건수(건)')
pl.title('특정 질병의 응급실 방문 현황')
pl.show()
