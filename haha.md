API: https://domain.com/in.php

Method Code: GET / POST

+ Parameter:

&method: haha

&key: point_xxx

&pageurl: link web hiển thị haha mà bạn thấy

&sitekey: xem iframe hiển thị haha trong web mà bạn thấy

# Bắt buộc phải có Proxy đi kèm
```
Cách sử dụng proxy (HTTP, HTTPS, SOCKS4, SOCKS5) của riêng bạn thì thêm: 

&proxy=username:password@123.123.123.123:3128&proxytype=HTTP
```

( Cách dùng y chang 2captcha )

Demo: GET/POST: https://domain.com/in.php?key=point_xxx&method=haha&pageurl=https://xxx.com/demo/haha&sitekey=xxx-xxx-xxx-xxx-xxxxxxxxxxx

Kết quả trả về: OK|6353b3f407a9b4417aac965d

6353b3f407a9b4417aac965d chính là ID

Demo: GET/POST: https://domain.com/res.php?key=point_xxx&action=get&id=6353b3f407a9b4417aac965d

Mỗi 5s request 1 lần để chờ server giải xong sẽ trả về kết quả

Nếu Server giải chưa xong, sẽ báo là: CAPCHA_NOT_READY

Bạn lại delay 5 giây rồi request lên res.php lại, cho đến khi:

Có kết quả trả về ở dạng: OK|xyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJwYxxxxx...

xyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJwYxxxxx... chính là TOKEN cần dùng.
