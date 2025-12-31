# fun Image v2

## Hình ảnh minh họa

### Loại mask_match
![mask_match](/img/v2/fun_v2.PNG)

### Loại finger_direction
![finger_direction](/img/v2/fun_v2.2.PNG)

### Loại icon_connect
![icon_connect](/img/v2/fun_v2.3.PNG)

---

## Danh Sách Câu Hỏi (imginstructions)

Xem chi tiết tại: [fun Answer](docs-fun-answer.md)

---

## Các loại hình ảnh cần lấy

### 1. finger_direction
![finger_direction](/img/v2/finger_direction.001.jpg)

### 2. hopscotch
![hopscotch](/img/v2/hopscotch.001.jpg)

### 3. icon_connect
![icon_connect](/img/v2/icon_connect.001.jpg)

### 4. mask_match
![mask_match](/img/v2/mask_match.001.jpg)

---

## Hướng dẫn GET URL và chuyển về Base64

1. Vào trang hiển thị captcha, click Authen hoặc Next cho hiển thị câu hỏi và captcha
2. Chuột phải vào tấm ảnh và chọn "inspect" để hiện tab developer debug
3. Trong tab "Elements", tìm line debug trong khu vực "iframe"
4. Tìm element "img" có "background-img" chứa nội dung kiểu `blob:https://xxx`

Ví dụ:
```html
<img aria-label="Image 1 of 12." class="sc-7csxyx-1 blHsFq" style="background-image: url(&quot;blob:https://client-api.arkoselabs.com/32dc3326-13bb-48a0-858d-f312bafd2329&quot;);">
```

5. Copy nguyên URL đó, bao gồm cả "blob:"
   - Ví dụ: `blob:https://client-api.arkoselabs.com/32dc3326-13bb-48a0-858d-f312bafd2329`
6. Mở URL đó trong tab mới của chrome, nếu thấy ảnh dạng cells thì đã GET đúng
7. Chuyển nó về Base64

### Đoạn code JavaScript mẫu để chuyển link Blob về Base64

```javascript
const getBase64FromUrl = async (url) => {
  const data = await fetch(url);
  const blob = await data.blob();
  return new Promise((resolve) => {
    const reader = new FileReader();
    reader.readAsDataURL(blob);
    reader.onloadend = () => {
      const base64data = reader.result;
      resolve(base64data);
    }
  });
}

var Base64Code = await getBase64FromUrl("blob:https://client-api.arkoselabs.com/32dc3326-13bb-48a0-858d-f312bafd2329").then(function(base64data)
{
  return base64data.split(";base64,")[1];
});
```

---

## Tham khảo

- Cách sử dụng tương tự với [fun Image v1](docs-fun-image.md)
- Danh sách câu hỏi: [fun Answer](docs-fun-answer.md)
- Json Postman demo: [Download](https://captcha69.com/postman/postman-fun-captcha69.zip)

![Postman Demo](/img/postman-fun.png)
