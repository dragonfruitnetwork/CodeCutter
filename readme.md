# DragonFruit CodeCutter

[![Codacy Badge](https://api.codacy.com/project/badge/Grade/8a1e425c2ae9466db78625de2446d0f9)](https://app.codacy.com/gh/dragonfruitnetwork/codecutter?utm_source=github.com&utm_medium=referral&utm_content=dragonfruitnetwork/CodeCutter&utm_campaign=Badge_Grade_Dashboard) ![Build & Release](https://github.com/dragonfruitnetwork/CodeCutter/workflows/Build%20&%20Release/badge.svg?branch=release)

## Overview
CodeCutter is a simple Windows tool that allows developers to get code quality feedback based on their pre-existing ReSharper Config. It uses the free Command Line tools, which are available to download from the JetBrains site. This tool is designed to be quick and easy to use, with the ability to hide certain levels of "issues" found. It can also be used to return an exit code other than `0`, which on CI servers, can also lead to the build failing (which will alert the PR opener that there are code quality issues).

As the ReSharper tools are currently Windows-only, so is this program.

## How to use
- Add a new build job to your CI  (or on GitHub Actions a new workflow file)
- Inside the job, add the checkout stage (if on GitHub)
- Set the server to download the latest copy of CodeCutter from [GitHub Releases](https://github.com/dragonfruitnetwork/CodeCutter/releases/latest/download/DragonFruit.CodeCutter.exe) (copy the link - it'll auto download the latest version)
- Run the .exe (with an optional argument pointing to a `codecutter.json` (absolute or relative) file)
	> If a config file argument if not set, CodeCutter will try to find a solution file and write a default config
- It'll analyse your code and print a nice list of all the issues and their locations, along with an overview at the end

## `codecutter.json` Setup
See the below example. Note JSON can't contain comments - these are just for explaining the process
> The default values are used in this example, except for the `solution` property
```
{
  //relative to the DragonFruit.CodeCutter.exe path
  "solution": "DragonFruit.CodeCutter.sln",
  
  //issue severity to warrant displaying it in the output
  "displayLevel": 3,
  
  //issue severity to warrant failing the build
  "errorLevel": 4
}
```
Issue Severity is ranked out of 5 levels: 
- `Hint` = 0
- `Suggestion` = 1
- `Warning` = 2
- `Error` = 3
- `None` = 4
