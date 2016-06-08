# ASP.NET Core Starter Kit `|>` F# &nbsp; ![Status](https://img.shields.io/badge/status-early%20preview-orange.svg?style=flat-square) [![Tips](https://img.shields.io/badge/donate-PayPal-blue.svg?style=flat-square)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=S7EE6P6KDLP9S)

> [ASP.NET Core Starter Kit](https://github.com/kriasoft/aspnet-starter-kit) is an opinionated
> boilerplate for web development based on [.NET Core](http://dotnet.github.io/),
> [Kestrel](https://github.com/aspnet/KestrelHttpServer), [GraphQL](http://graphql.org/) on the
> backend and [Babel](http://babeljs.io/), [Webpack](https://webpack.github.io/),
> [React](https://facebook.github.io/react) on the frontend. This boilerplate comes in both
> [C#](https://github.com/kriasoft/aspnet-starter-kit) and
> [F#](https://github.com/kriasoft/fsharp-starter-kit) flavors.


### Features

&nbsp; &nbsp; ✓ Component-based front-end development with [Webpack](https://webpack.github.io/), [CSS Modules](https://github.com/css-modules/css-modules) and [React](https://facebook.github.io/react) (see [`tools/webpack.config.js`](./tools/webpack.config.js))<br>
&nbsp; &nbsp; ✓ Modern JavaScript syntax ([ES2015](http://babeljs.io/docs/learn-es2015/)+) via [Babel](http://babeljs.io/); modern CSS syntax (CSS3+) via [PostCSS](https://github.com/postcss/postcss)<br>
&nbsp; &nbsp; ✓ Application state management via [Redux](http://redux.js.org/) (coming soon)<br>
&nbsp; &nbsp; ✓ Routing and navigation via [React App](https://github.com/kriasoft/react-app), [Universal Router](https://github.com/kriasoft/universal-router) and [History](https://github.com/mjackson/history) `npm` modules<br>
&nbsp; &nbsp; ✓ [Code-splitting](https://github.com/webpack/docs/wiki/code-splitting) and async chunk loading with [Webpack](https://webpack.github.io/) and [ES6 System.import()](http://www.2ality.com/2014/09/es6-modules-final.html)<br>
&nbsp; &nbsp; ✓ Hot Module Replacement ([HMR](https://webpack.github.io/docs/hot-module-replacement.html)) /w [React Hot Loader](http://gaearon.github.io/react-hot-loader/) (coming soon)<br>
&nbsp; &nbsp; ✓ Cross-device testing with [Browsersync](https://browsersync.io/) (coming soon)<br>
&nbsp; &nbsp; ✓ Git-based deployment to [Azure App Service](https://azure.microsoft.com/services/app-service/) (see [`tools/deploy.js`](./tools/deploy.js))<br>
&nbsp; &nbsp; ✓ 24/7 community support on [Gitter](https://gitter.im/kriasoft/aspnet-starter-kit) or [StackOverflow](http://stackoverflow.com/questions/tagged/aspnet-starter-kit); customization requests on [Codementor](https://www.codementor.io/koistya)<br>


### Directory Layout

```shell
.
├── /.vscode/                   # Visual Studio Code settings
├── /build/                     # The folder for compiled output
├── /client/                    # Client-side app (frontend)
├── /client.test/               # Unit and integration tests for the frontend app
├── /public/                    # Static files such as favicon.ico etc.
├── /server/                    # Web server and data API (backend)
├── /server.test/               # Unit and integration tests for the backend app
├── /tools/                     # Build automation scripts and utilities
│── jsconfig.json               # Visual Studio Code settings for JavaScript
│── LICENSE.txt                 # Licensing information
│── package.json                # The list of project dependencies and NPM scripts
└── README.md                   # Project overview / getting started guide
```


### Prerequisites

* OS X, Windows or Linux
* [Node.js](https://nodejs.org) v6 or newer
* [.NET Core v1.0 RC2](https://blogs.msdn.microsoft.com/dotnet/2016/05/16/announcing-net-core-rc2/)
* [Visual Studio Code](https://code.visualstudio.com/) or [Atom](https://atom.io/) with [F# extension](http://ionide.io/)


### Getting Started

`1`. Clone the latest version of **ASP.NET Core Starter Kit** on your local machine by running:

```shell
$ git clone -o fsharp-starter-kit -b master --single-branch \
      https://github.com/kriasoft/fsharp-starter-kit.git MyApp
$ cd MyApp
```

`2`. Install project dependencies listed in [`project.json`](./server/project.json) and
[`package.json`](./package.json) files: 

```shell
$ dotnet restore                # Installs .NET dependencies listed in project.json
$ npm install                   # Installs Node.js dependencies listed in package.json
```

`3`. Finally, launch the web app:

```shell
$ npm start                     # Compiles and lanches the app
```

The app should become available at [http://localhost:5000/](http://localhost:5000/)


### How to Deploy

Before you can deploy your app to [Azure App Service](https://azure.microsoft.com/services/app-service/),
you need to open Web App settings in [Azure Portal](https://portal.azure.com/), go to "Deployment
Source", select "Local Git Repository" and hit [OK]. Then copy and paste "Git clone URL" of your
Web App into [`tools/deploy.js`](./tools/deploy.js) file. Then, whenever you need to compile your
app into a distributable format and upload that to Windows Azure App Service, simply run:

```shell
$ npm run deploy                # Same as running: node tools/deploy --production
```


### References

<table width="100%">
  <tr>
    <td width="185">
      <a href="http://amzn.to/1UufBR9">
        <img src="http://ecx.images-amazon.com/images/I/41y1%2BeGsX3L._SX150.jpg" width="150" height="214" alt="Beginning F# 4.0" />
      </a>
    </td>
    <td>
      <p>
        <strong><a href="http://amzn.to/1UufBR9">Beginning F# 4.0</a>, 2nd Edition</strong><br />
        <sup>by Robert Pickering, Kit Eason (Jun 2016)</sup>
      </p>
      <p>
        This book is a great foundation for exploring functional-first programming and its role in
        the future of application development. The best-selling introduction to F#, now thoroughly
        updated to version 4.0, will help you learn the language and explore its new features
      </p>
    </td>
  </tr>
  <tr>
    <td width="185">
      <a href="http://amzn.to/1U4dKp1">
        <img src="http://ecx.images-amazon.com/images/I/31YI7c5ZCbL._SX150.jpg" width="150" height="214" alt="Expert F# 4.0" />
      </a>
    </td>
    <td>
      <p>
        <strong><a href="http://amzn.to/1U4dKp1">Expert F# 4.0</a>, 4th Edition</strong><br />
        <sup>by Don Syme, Adam Granicz, Antonio Cisternino (Dec 2016)</sup>
      </p>
      <p>
        Learn from F#'s inventor to become an expert in the latest version of this powerful
        programming language so you can seamlessly integrate functional, imperative,
        object-oriented, and query programming style flexibly and elegantly to solve any
        programming problem. Expert F# 4.0 will help you achieve unrivaled levels of programmer
        productivity and program clarity across multiple platforms including Windows, Linux,
        Android, OSX, and iOS as well as HTML5 and GPUs.
      </p>
    </td>
  </tr>
</table>


### Related Projects

* [React Starter Kit](https://github.com/kriasoft/react-starter-kit) — Isomorphic web app boilerplate (Node.js, Express, GraphQL, React)
* [Babel Starter Kit](https://github.com/kriasoft/babel-starter-kit) — JavaScript library boilerplate (ES2015+, Babel, Rollup)
* [ASP.NET Core Starter Kit](https://github.com/kriasoft/aspnet-starter-kit) — Web app boilerplate (C#, .NET Core, Kestrel, GraphQL, React)
* [Universal Router](https://github.com/kriasoft/universal-router) — Isomorphic router for web and single-page applications (SPA)
* [Membership Database](https://github.com/membership/membership.db) — SQL database boilerplate for web app users, roles and auth tokens


### Get in Touch

* [#fsharp-starter-kit](https://gitter.im/kriasoft/fsharp-starter-kit) on Gitter
* [@koistya](https://twitter.com/koistya) on [Codementor](https://www.codementor.io/koistya)


### License

Copyright © 2014-2016 [Kriasoft](https://kriasoft.com). This source code is licensed under the MIT
license found in the [LICENSE.txt](https://github.com/kriasoft/fsharp-starter-kit/blob/master/LICENSE.txt)
file. The documentation to the project is licensed under the [CC BY-SA 4.0](http://creativecommons.org/licenses/by-sa/4.0/)
license.


---
Made with ♥ by Konstantin Tarkus ([@koistya](https://twitter.com/koistya)) and [contributors](https://github.com/kriasoft/fsharp-starter-kit/graphs/contributors)
