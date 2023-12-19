import json
import urllib.request

myurl = 'https://api.odcloud.kr/api/3047940/v1/uddi:633f7dab-ffb5-4843-bc65-bd7f3b99dfa2?page=1&perPage=1000&serviceKey=MfKZl8f8O7MhFaujSYXlnStV6EXfUl3j66hRIC7INogJmsfjOJUVV21KPi4%2BOhZg3CGujV4CwcuTn6su2x9k8w%3D%3D'

response = urllib.request.urlopen(myurl)
response = response.read().decode('utf8')

print(response)

data = json.loads(response)
json_arr = data['data']
for item in json_arr:
    print(f"식당명:{item['상호명']}, 대표메뉴:{item['주메뉴']}")