```
AE dùng phần mềm này để chuyển đổi proxy trên VPS nha: https://github.com/nttrung9x/captcha69.com/blob/main/tools-conver-proxy.md
```
- v1: 1 requests = 4 point
- v2: 1 requests = 1 point
- Create Task:
```
- Thông số:
POST:
API: https://captcha69.com/fun_token.php
Params:
?key=API_KEY
&action=create
&sv=1
&json=1
&public_key=SITE_KEY
&page_url=PAGE_URL
&proxy_info=proxy
&user_agent=user_agent
&data_blob=xxx ( thông số không bắt buộc - tùy site cần hoặc không )
```
```
Ví dụ:
POST:
API: https://captcha69.com/fun_token.php
Params:
?key=point_xxx
&action=create
&sv=1
&json=1
&public_key=C07CAFBC-F76F-4DFD-ABFA-A6B78ADC1F29
&page_url=https://help.x.com
&proxy_info=http://username:password@ip:port Hoặc http://ip:port Hoặc socks5://...
&user_agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36
&data_blob=xxx ( thông số không bắt buộc - tùy site cần hoặc không )
```
- Tạo task xong thì phải chờ ít nhất 5 giây thì mới get task nha, nếu không sẽ bị lỗi NOT_FIND_ID
- Response - Kết quả trả về:
```
{
  "status": "SUCCESS",
  "request": "665f0b4b8507db722cb107fe"
}
```
![Create Task](PostMan-fun-v2-create.png)


- Result Task:
```
GET:
API: https://captcha69.com/fun_token.php
?key=API_KEY
&action=get
&json=1
&id=TASK_ID
```
```
Ví dụ:
GET:
API: https://captcha69.com/fun_token.php
?key=point_xxx
&action=get
&json=1
&id=665f0b4b8507db722cb107fe
```
Response - Kết quả trả về:
```
status is 3 result: ERROR ( giải lỗi ) | PROCESSING ( đang giải ) | SUCCESS ( giải xong )
```
```
{
  "status": "SUCCESS",
  "request": "12017d5cd8966fb68.4052468405|r=eu-west-1|meta=3|meta_width=558|meta_height=523|metabgclr=transparent|metaiconclr=%23555555|guitextcolor=%23000000|lang=vi|pk=2CB16598-CB82-4CF7-B332-5990DB66F3AB|at=40|ag=101|cdn_url=https%3A%2F%2Fclient-api.arkoselabs.com%2Fcdn%2Ffc|lurl=https%3A%2F%2Faudio-eu-west-1.arkoselabs.com|surl=https%3A%2F%2Fclient-api.arkoselabs.com|smurl=https%3A%2F%2Fclient-api.arkoselabs.com%2Fcdn%2Ffc%2Fassets%2Fstyle-manager"
}
```
- Chú ý:
```
Khi ae requests cùng 1 proxy từ 1 đến 2 lần nhưng vẫn cứ nhận được ERROR thì nên đổi proxy khác nha, vì đôi khi proxy đó bị Fun nó black list rồi, qua ngày khác thì có khả năng dùng lại được
```

- Code mẫu submit token fun:
```
https://github.com/nttrung9x/captcha69.com/blob/main/submit-fun-token.md
```
