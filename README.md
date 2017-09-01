# FullStackTemplate

## Licence
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## Description

A .NET Core WebApi and MVC application template.

The solution is split into several different projects:

- UI
- Facades (optional)
- DAL
- Persistence
- Config

### Licence Details

It has been released, as is, using an MIT licence. For more information on the MIT licence, please see either the `LICENSE` file in the root of the repository or see the tl;dr Legal page for [MIT](https://tldrlegal.com/license/mit-license)

## Code of Conduct
Wilf has a Code of Conduct which all contributors, maintainers and forkers must adhere to. When contributing, maintaining, forking or in any other way changing the code presented in this repository, all users must agree to this Code of Conduct.

See `Code of Conduct.md` for details.

### Using This Template

To install this template rename the `template.config` directory to `.template.config`, then run the following command

    dotnet new --install FullStackTemplate

To confirm that the new template was installed, run the following command

    dotnet new -l

To create a new project (called MyProject) based on this template, run the following command

    dotnet new fullstack --name MyProject