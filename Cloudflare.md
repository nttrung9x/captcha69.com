# Normal Turnstile

POST: https://captcha69.com/createTask
```
{
	"clientKey":"API_KEY_max1",
	"task":
	{
		"type":"TurnstileTaskProxyless",
		"websiteURL":"https://domain.com",
		"websiteKey":"0x4AAAAxxxxxxxxx"
	}
}
```

Response
```
{
  "errorId":0,
  "taskId":676869 
}
```

# CloudFlare (token)

POST: https://captcha69.com/createTask
```
{
	"clientKey": "API_KEY_max1",
	"task": {
		"type": "TurnstileTask",
		"websiteURL": "https://domain.com",
		"websiteKey": "0x4AAAAxxxxxxxxx",
		"cloudflareTaskType": "token",
		"userAgent":"userAgent_For_Browser",
		"pageAction": "managed",
		"pageData": "HUHDWUHuxxxxxxxxxx=",
		"data": "695147f4retD6869"
	}
}
```

Response
```
{
  "errorId":0,
  "taskId":676869 
}
```

# CloudFlare(cookie)

POST: https://captcha69.com/createTask
```
  {
  "clientKey":"API_KEY_max1",
  "task": {
	"type":"TurnstileTask",
	"websiteURL":"https://domain.com",
	"websiteKey":"0x4AAAAxxxxxxxxx",
	"cloudflareTaskType": "cf_clearance",
	"htmlPageBase64": "PCFETxxxxxxxxx+",
	"userAgent": "userAgent_For_Browser",
	"proxyType":"http",
	"proxyAddress":"xxx.xxx.xxx.xxx",
	"proxyPort":xxxx,
	"proxyLogin":"ProxyUsername",
	"proxyPassword":"ProxyPassword"
  }
}
```

Response
```
{
  "errorId":0,
  "taskId":676869
}
```


# Get Token By taskId

POST: https://captcha69.com/getTaskResult
```
{
  "clientKey":"API_KEY_max1",
  "taskId": 676869
}
```

Response is in process - wait for 5s and re-post
```
{
  "errorCode": null,
  "errorDescription": null,
  "errorId": 0,
  "status": "processing"
}
```

Successful response
```
{
    "solution": {
        "token": "0.lzLtMryi1Rj2W76EJJ_WkAUFd-fo7rlLr-FKo-4gpiv-K5g1Jwzsfoa2TeX5o3f2OetMnndzDj6R0OsMkqW-xxxxxxx"
    },
    "status": "ready",
    "errorId": 0,
    "errorCode": null,
    "errorDescription": null
}
```

# demo code NodeJS

```

const { Builder } = require('selenium-webdriver');
const chrome = require('selenium-webdriver/chrome');

(async function example() {
  const options = new chrome.Options();
  options.addArguments('--auto-open-devtools-for-tabs');

  const driver = new Builder()
    .forBrowser('chrome')
    .setChromeOptions(options)
    .build();

  try {
    driver.executeScript(`
    window.turnstile = new Proxy(window.turnstile, {
      get(target, prop) {
        if (prop === 'render') {
          return function(a, b) {
            let p = {
              type: "TurnstileTaskProxyless",
              websiteKey: b.sitekey,
              websiteURL: window.location.href,
              data: b.cData,
              pagedata: b.chlPageData,
              action: b.action,
              userAgent: navigator.userAgent
          }
          console.log(JSON.stringify(p));
          window.params = p;
          window.turnstileCallback = b.callback;
            return target.render.apply(this, arguments);
          }
        }
        return target[prop];
      }
    });
    `)

    driver.get('https://domain.com');
    
    const params = await driver.executeScript(`
      return new Promise((resolve, reject) => {
        setTimeout(() => {
          resolve(window.params)
        }, 2000)
      })
    `);

    if (params) {
      const data = {
        clientKey: 'API_KEY_max1',
        task: {
          type: 'TurnstileTaskProxyless',
          websiteURL: params.websiteURL,
          websiteKey: params.websiteKey,
          data: params.data,
          action: params.action
        }
      }

      const createResult = await fetch('https://captcha69.com/createTask', {
        method: 'post',
        body: JSON.stringify(data)
      });

      const createTaskResult = await createResult.json()
      if (createTaskResult.taskId) 
	  {
        const asyncDelay = (timeout) =>
          new Promise(resolve => {
              setTimeout(() => {
                  resolve();
              }, timeout);
          });
        
        const getTaskResult = async (taskId) => {
          const taskResult = await fetch('https://captcha69.com/getTaskResult', {
            method: 'post',
            body: JSON.stringify({
              "clientKey":"API KEY",
              "taskId": createTaskResult.taskId
            })
          });
          const taskResponse = await taskResult.json();
          if (taskResponse.status === 'processing') {
            await asyncDelay(5000);
            return await getTaskResult(taskId)
          }
          return taskResponse;
        }
       
        const taskRes = await getTaskResult(createTaskResult.taskId)
        if (taskRes.solution) {
          await driver.executeScript(`
            window.turnstileCallback(${taskRes.solution.token});
          `);
        }
      }
    }
  } finally {
    await driver.quit();
  }
})();
```
