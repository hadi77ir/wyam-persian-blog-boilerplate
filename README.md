# Persian Blog boilerplate for Wyam

Contains a boilerplate for `Blog` recipe with a translated, RTL-ized [CleanBlog](https://github.com/Wyamio/Wyam/tree/develop/themes/Blog/CleanBlog) theme for [Wyam](https://wyam.io).

## Features

1. [Vazir](https://rastikerdar.github.io/vazir-font/) font
2. [Bootstrap RTL Ondemand](https://github.com/bright/bootstrap-rtl)
3. Translated to Persian
4. Customizations on pipelines for Persian translation
5. Jalali date (using [PersianDateTimeFormat](https://github.com/hadi77ir/PersianDateTimeFormat))
6. A simple [Cake](https://cakebuild.net/) build script

## Usage

Clone this repository by running

```
git clone https://github.com/hadi77ir/wyam-persian-blog-boilerplate
```

or downloading the repo as a zip file and extracting it.

Edit `config.wyam` and change values of `BlogKeys`  to yours.

### Building

Either execute `wyam build` or Cake bootstrapper (`.\build.ps1`).

The Cake bootstrapper automatically sets up Wyam.

## License

MIT

## Happy blogging!

