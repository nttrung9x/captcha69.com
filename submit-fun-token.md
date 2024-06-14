- Cách gửi mã thông báo Twitter Funcaptcha
- Đầu tiên, bạn phải tập trung vào iframe có id "arkoseFrame"

- Với mã Selenium

-Chuyển iframe bằng mã C#:
```
driver.SwitchTo().Frame(driver.FindElement(By.Id("arkoseFrame")));
```

-Chuyển iframe bằng mã Python:
```
driver.switch_to.frame(driver.find_element(By.ID, 'arkoseFrame'));
```
- Chuyển iframe bằng mã Java:
```
WebElement iframe = driver.findElement(By.id("arkoseFrame"));
```

- Switch to the frame
- ```
driver.switchTo().frame(iframe);
```

- Gửi mã thông báo:
```
function submit(token) {
    parent.postMessage(JSON.stringify({
        eventId: "challenge-complete",
        payload: { sessionToken: token }
    }), "*");
}
submit("token_here");
```
Với token_here là Mã thông báo Funcaptcha bạn nhận được từ dịch vụ [CaptCha69.Com](https://captcha69.com/)
