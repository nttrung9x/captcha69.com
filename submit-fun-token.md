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
```
driver.switchTo().frame(iframe);
```

- Submit Fun Token:
```
var Token_FunCaptCha = "Truyền token nhận đc từ api vào đây - xem ví dụ phía dưới";
var Js_Submit = @"
function submit(token) {
    parent.postMessage(JSON.stringify({
        eventId: 'challenge-complete',
        payload: { sessionToken: token }
    }), '*');
}
submit('"+Token_FunCaptCha+"');
";

driver.execute_script(Js_Submit); // inject javascripts code submit token vào trình duyệt trong selenium
```

- Với Token_FunCaptCha là Code thông báo Funcaptcha bạn nhận được từ dịch vụ [CaptCha69.Com](https://captcha69.com/)
- Token_FunCaptCha có dạng:
```
12017d5cd8966fb68.4052468405|r=eu-west-1|meta=3|meta_width=558|meta_height=523|metabgclr=transparent|metaiconclr=%23555555|guitextcolor=%23000000|lang=vi|pk=2CB16598-CB82-4CF7-B332-5990DB66F3AB|at=40|ag=101|cdn_url=https%3A%2F%2Fclient-api.arkoselabs.com%2Fcdn%2Ffc|lurl=https%3A%2F%2Faudio-eu-west-1.arkoselabs.com|surl=https%3A%2F%2Fclient-api.arkoselabs.com|smurl=https%3A%2F%2Fclient-api.arkoselabs.com%2Fcdn%2Ffc%2Fassets%2Fstyle-manager
```








