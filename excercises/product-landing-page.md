<file name=0 path=/Users/marcinsulecki/Projects/blazor-starter/excercises/product-landing-page.md># 🛍️ Task: Product page with preview and QR code

## 🧩 Goal:

Your task is to create a page presenting product information in the form of a simple *landing page*. The page should contain basic product details, and optionally – also a generated QR code with a link to the product page.
The goal of the task is to learn how to build components in Blazor and how to pass data.

---

## ✅ Functional Requirements:

1. **Create a Blazor page** `Pages/Products/View.razor`
2. On the page, **display basic product information**:
- Product name `Name`
- Description `Description`
- Price `Price`
3. **Display the product image** based on the `ImageUrl` field


## 🧠 Extension (optional):

- Add a `QrCode.razor` component that allows displaying a QR code containing a link to the product page.
- Add a `Value` parameter – the content of the QR code (e.g., the full URL of the product page)
- Add a `Size` parameter *(optional)* – the size of the generated QR code in pixels (default is `200`)


### 👉 To generate the QR code use an external API 
```bash
https://api.qrserver.com/v1/create-qr-code/?data=...&size=...
```

### 💡 Example usage of the QR component:

```razor
<QrCode Value="https://yourdomain.com/products/123" Size="150" />
```


## 📌 Tips
- For testing, you can hardcode any sample product page 
(e.g., `https://localhost:5001/products/abc123`)

- The `QrCode.razor` component can generate an `<img>` with the appropriate API URL as the source

---


## ⏱️ Estimated Time: **45 minutes**


If you have any questions — ask the trainer 🙂