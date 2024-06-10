
- Create Task:
```
GET: https://captcha69.com/in.php?key=API_KEY&method=fun_token&json=1&pageurl=SITE_KEY|PAGE_URL
```
```
GET: https://captcha69.com/in.php?key=point_xxx&method=fun_token&json=1&pageurl=2CB16598-CB82-4CF7-B332-5990DB66F3AB|https://x.com/i/flow/signup
```
Response
```
{
  "status": 1,
  "request": "665f0b4b8507db722cb107fe"
}
```



- Result Task:
```
GET: https://captcha69.com/res.php?key=API_KEY&action=get&json=1&id=TASK_ID
```
```
GET: https://captcha69.com/res.php?key=point_xxx&action=get&json=1&id=665f0b4b8507db722cb107fe
```
Response
```
status is 3 result: ERROR ( giải lỗi ) | PROCESSING ( đang giải ) | SUCCESS ( giải xong )
```
```
{
  "status": "SUCCESS",
  "request": "12017d5cd8966fb68.4052468405|r=eu-west-1|meta=3|meta_width=558|meta_height=523|metabgclr=transparent|metaiconclr=%23555555|guitextcolor=%23000000|lang=vi|pk=2CB16598-CB82-4CF7-B332-5990DB66F3AB|at=40|ag=101|cdn_url=https%3A%2F%2Fclient-api.arkoselabs.com%2Fcdn%2Ffc|lurl=https%3A%2F%2Faudio-eu-west-1.arkoselabs.com|surl=https%3A%2F%2Fclient-api.arkoselabs.com|smurl=https%3A%2F%2Fclient-api.arkoselabs.com%2Fcdn%2Ffc%2Fassets%2Fstyle-manager"
}
```
