# fun Image

## Ví Dụ

### Ví Dụ Cho Câu Hỏi: penguins
![penguins](https://raw.githubusercontent.com/nttrung9x/captcha69.com/main/fun-img/img/penguins.jpg)

- `&imginstructions=penguins`
- Kết quả: `OK|2`

---

### Ví Dụ Cho Câu Hỏi: shadow_puppets
![shadow_puppets](https://raw.githubusercontent.com/nttrung9x/captcha69.com/main/fun-img/img/shadow_puppets.jpg)

- `&imginstructions=shadow_puppets`
- Kết quả: `OK|3`

---

## Cách GET URL và Chuyển Về Base64

Xem chi tiết tại: [fun Image v2](docs-fun-image-v2.md)

---

## Danh Sách Câu Hỏi (imginstructions)

Xem chi tiết tại: [fun Answer](docs-fun-answer.md)

---

## Hướng Dẫn Sử Dụng

### API Endpoint
- URL: `https://captcha69.com/in.php`
- Method: `POST`

### Parameters
| Parameter | Mô tả |
|-----------|-------|
| `body` | Captcha image content với Base64 Encode |
| `key` | API key (định dạng: `point_YOUR_KEY`) |
| `method` | `base64` |
| `imginstructions` | Câu hỏi đã lọc |
| `json` | `0` |

### Demo Request

```
POST https://captcha69.com/in.php?json=0&key=point_YOUR_KEY&method=base64&imginstructions=shadow_puppets&body=/9j/2wCEAA...
```

### Kết quả trả về

```
OK|63b9df32961ccf10c30e82d9
```

`63b9df32961ccf10c30e82d9` là ID và sẽ thay đổi mỗi lần request

### Lấy kết quả

```
GET/POST https://captcha69.com/res.php?key=point_YOUR_KEY&action=get&id=63b9df32961ccf10c30e82d9
```

Kết quả: `OK|ket_qua`

Số `3` chính là vị trí ảnh cần click trong Grid image

---

## Test API

- Lấy Base64 Images để test: [https://captcha69.com/test-api-img.php](https://captcha69.com/test-api-img.php)
- Nhớ xóa phần: `data:image/jpeg;base64,`

## Postman Demo
![Postman Demo](https://raw.githubusercontent.com/nttrung9x/captcha69.com/main/fun-img/img/postman-fun.png)

