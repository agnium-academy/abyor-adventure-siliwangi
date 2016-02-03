# Petualangan Siliwangi API

## Project WebAPP with RESTful API

* Nama Project: Students
* Version : 1.0
* Tanggal	: 3 Februari 2016
* Team: Siliwangi (Dwi Okta, Sofi, Trio, Ucu Nurul)
* Deskripsi	: Building Simple WEB APP Architecture with RESTful API
* Development kit:
  - Visual Studio 2015
  - C# (Back-End)
  - ASP.NET (Front-End)

### Packages

* Install-Package microsoft.aspnet.mvc -version 5.1.1
* Install-Package microsoft.aspnet.webapi -version 5.1.1
* Install-Package Newtonsoft.json -version 6.0.1
* Install-Package jquery -version 2.1.0
* Install-Package bootstrap -version 3.1.1
* Install-Package knockoutjs –version 3.1.0

### Database

* Ms SQL Server 2014

*  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *

## Mini Project Roadmap

1. Data yang ditampilkan (hardcode dulu saja):

```
{
  "nama": "Agus",
  "alamat": "Bogor",
  "umur": 17
}
```

2. Memunculkan data dari database .
3. Membuat banyak data lebih dari 10.
4. Filter (exact). Contoh: `/api/route?nama="agus"`
5. Filter (like). Contoh: `/api/route?nama="gu"`
6. DELETE
7. POST (Create)
8. PUT (Update)

*  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *

## Log

### 3 Februari 2016:

- Membuat Project di Visual Studio berbasis Web Application (MVC dan API)
- Menampilkan Data Students (GET)
- Menampilkan Data Students > 10 entries
- Atribut Students yaitu: ID, Nama, Alamat, Umur
- Melakukan filter exact dan filter like
- Melakukan fungsi Delete
- Melakukan fungsi POST by URL
- Melakukan fungsi PUT
