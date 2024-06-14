- Cách gửi mã thông báo Funcaptcha Token
- Đầu tiên, bạn phải tập trung vào iframe có id "arkoseFrame"

- Với Code Selenium

- Chuyển iframe bằng Code C#:
```
driver.SwitchTo().Frame(driver.FindElement(By.Id("arkoseFrame")));
```

- Chuyển iframe bằng Code Python:
```
driver.switch_to.frame(driver.find_element(By.ID, 'arkoseFrame'));
```
- Chuyển iframe bằng Code Java:
```
WebElement iframe = driver.findElement(By.id("arkoseFrame"));
```

- Switch to the frame
- ```
driver.switchTo().frame(iframe);
```

- Submit Fun Token:
```
function submit(token) {
    parent.postMessage(JSON.stringify({
        eventId: "challenge-complete",
        payload: { sessionToken: token }
    }), "*");
}
submit("token_here");
```
- Với token_here là Code thông báo Funcaptcha bạn nhận được từ dịch vụ [CaptCha69.Com](https://captcha69.com/)
- token_here có dạng:
```
12017d5cd8966fb68.4052468405|r=eu-west-1|meta=3|meta_width=558|meta_height=523|metabgclr=transparent|metaiconclr=%23555555|guitextcolor=%23000000|lang=vi|pk=2CB16598-CB82-4CF7-B332-5990DB66F3AB|at=40|ag=101|cdn_url=https%3A%2F%2Fclient-api.arkoselabs.com%2Fcdn%2Ffc|lurl=https%3A%2F%2Faudio-eu-west-1.arkoselabs.com|surl=https%3A%2F%2Fclient-api.arkoselabs.com|smurl=https%3A%2F%2Fclient-api.arkoselabs.com%2Fcdn%2Ffc%2Fassets%2Fstyle-manager
```







.
