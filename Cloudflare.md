# Normal Turnstile

POST: https://captcha69.com/createTask
```
{
	"clientKey":"API_KEY",
	"task":
	{
		"type":"TurnstileTaskProxyless",
		"websiteURL":"http://tsmanaged.zlsupport.com",
		"websiteKey":"0x4AAAAAAABUYP0XeMJF0xoy"
	}
}
```

Response
```
{
  "errorId":0,
  "taskId":600b79db289ac9c3d691c5a5 
}
```

# CloudFlare (token)

POST: https://captcha69.com/createTask
```
{
	"clientKey": "API_KEY",
	"task": {
		"type": "TurnstileTask",
		"websiteURL": "https://site.com",
		"websiteKey": "0x4AAAAAAADnPIDROrmt1Wwj",
		"cloudflareTaskType": "token",
		"userAgent":"userAgentPlaceholder",
		"pageAction": "managed",
		"pageData": "HUHDWUHuhuwfiweh32..uh2uhuhyugYUG=",
		"data": "874291f4retD1366"
	}
}
```

Response
```
{
  "errorId":0,
  "taskId":600b79db289ac9c3d691c5a5 
}
```

# CloudFlare(cookie)

POST: https://captcha69.com/createTask
```
  {
  "clientKey":"API_KEY",
  "task": {
	"type":"TurnstileTask",
	"websiteURL":"https://nowsecure.nl",
	"websiteKey":"xxxxxxxxxx",
	"cloudflareTaskType": "cf_clearance",
	"htmlPageBase64": "PCFET0NUWVBFIGh0...vYm9keT48L2h0bWw+",
	"userAgent": "userAgentPlaceholder",
	"proxyType":"http",
	"proxyAddress":"8.8.8.8",
	"proxyPort":8080,
	"proxyLogin":"proxyLoginHere",
	"proxyPassword":"proxyPasswordHere"
  }
}
```

Response
```
{
  "errorId":0,
  "taskId":407533072
}
```
