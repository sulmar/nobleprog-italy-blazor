<file name=0 path=/Users/marcinsulecki/Projects/blazor-starter/excercises/product-search-panel.md># 🔍 Task: Product Search Panel and Details

## 🧩 Goal:

Your task is to extend the product list page with the ability to filter using parameters in the *query string* and to create a product details page with support for route parameters and an optional discount.
The goal of the task is to learn how to display data from the repository in a table format in a Blazor application.

---

##  ✅ Functional Requirements:

1. **Page** `ProductList.razor`
- Displays a list of all products (e.g. from `IProductService`)
- Supports filtering by color based on the query string:

**Example:**
```bash
/products?color=red
```

- For each product, add a “Details” button that:
	- redirects to `Product/View.razor`
	- passes `productId` as a route parameter
	- passes `discount=true` or `false` as a *query string*

---

## 💡 Example URLs

`/products?color=red` — shows products in red color

`/products/1?discount=true` — shows discounted price.

`/products/2?discount=false` — price without discount.

`/products/3` — no discount, default price.

---


## ⏱️ Estimated Time: **30 minutes**
If you have any questions — ask the trainer 🙂