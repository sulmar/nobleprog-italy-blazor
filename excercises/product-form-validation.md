# ✅ Task: Product Addition Form with Validation

## 🧩 Goal:
Your task is to create a Blazor form that allows adding a new product. The form should include input validation using **DataAnnotations** or **FluentValidation** (your choice). This exercise helps practice proper handling of validation and forms in Blazor applications.

---

## ✅ Functional Requirements

1. Form fields:
The form should contain the following fields:
- 🏷️ **Product Name** – required, maximum 20 characters
- 🆔 **Product Code** – required, matching the format `XXX-NNNNN` (e.g., `ABC-12345`)
- 🎨 **Color** – optional or selected from the list: `Red`, `Green`, `Blue`
- 💰 **Price** – required, greater than `0`, maximum `1999.99`
- 📝 **Description** – required, maximum 50 characters
- 📅 **Expiration Date** – required, **a future date**

---

## 🧪 Validation
- Invalid data should result in error messages displayed below the respective fields
- The form should not submit until all data is valid

You can use:
- `EditForm` + `DataAnnotationsValidator`
- or the `FluentValidation` library with Blazor

---

## 🧾 Form Handling

- After correctly filling out the form and clicking the “Save” button:
	- The console (Console.WriteLine) should display the message:
```text
Product saved successfully!
```

- We do not save data to a database or file – focus is on validation itself


## 🧠 Extension (optional)
- Add a `ValidationSummary` component above the form
- Add dynamic highlighting of valid/empty fields (CSS classes `is-valid` / `is-invalid`)
- Implement custom validation attributes (e.g., `ProductCodeAttribute`)

## ⏱️ Estimated Time: 45 minutes

If you have any questions — ask the trainer 🙂