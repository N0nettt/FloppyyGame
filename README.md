<p align="center">
  <img src="https://raw.githubusercontent.com/PKief/vscode-material-icon-theme/ec559a9f6bfd399b82bb44393651661b08aaf7ba/icons/folder-markdown-open.svg" width="100" alt="project-logo">
</p>
<p align="center">
    <h1 align="center">FLOPPYYGAME</h1>
</p>
<p align="center">
    <em>Soar through pipes with grace.</em>
</p>
<p align="center">
	<img src="https://img.shields.io/github/license/N0nettt/FloppyyGame?style=default&logo=opensourceinitiative&logoColor=white&color=0080ff" alt="license">
	<img src="https://img.shields.io/github/last-commit/N0nettt/FloppyyGame?style=default&logo=git&logoColor=white&color=0080ff" alt="last-commit">
	<img src="https://img.shields.io/github/languages/top/N0nettt/FloppyyGame?style=default&color=0080ff" alt="repo-top-language">
	<img src="https://img.shields.io/github/languages/count/N0nettt/FloppyyGame?style=default&color=0080ff" alt="repo-language-count">
<p>
<p align="center">
	<!-- default option, no dependency badges. -->
</p>

<br><!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary><br>

- [ Overview](#-overview)
- [ Features](#-features)
- [ Repository Structure](#-repository-structure)
- [ Modules](#-modules)
- [ Getting Started](#-getting-started)
  - [ Installation](#-installation)
  - [ Usage](#-usage)
  - [ Tests](#-tests)
- [ Project Roadmap](#-project-roadmap)
- [ Contributing](#-contributing)
- [ License](#-license)
- [ Acknowledgments](#-acknowledgments)
</details>
<hr>

##  Overview

FloppyyGame is a C# Windows game application that features a side-scrolling gameplay where a bird navigates pipes. The project includes essential components such as the main menu, game forms, and resource management for a smooth user experience. With functionalities like score tracking, pipe speed variation, and intuitive menu interactions, FloppyyGame offers users an engaging gaming experience within a visually appealing interface. The projects primary focus is on providing entertainment through gameplay mechanisms like gravity simulation, user input controls, and interactive visual elements.

---

##  Features

|    |   Feature         | Description |
|----|-------------------|---------------------------------------------------------------|
| ⚙️  | **Architecture**  | Windows Forms-based C# game project with clear separation of UI components and game logic, organized in a straightforward structure. |
| 🔩 | **Code Quality**  | Well-structured code with consistent naming conventions and clear comments, aiding readability and maintenance. |
| 📄 | **Documentation** | Adequate inline comments and README.md file providing basic setup instructions, lacking in-depth documentation. |
| 🔌 | **Integrations**  | Relies on standard C# libraries and Windows Forms GUI framework without significant external dependencies. |
| 🧩 | **Modularity**    | Codebase lacks extensive modularity, with limited potential for component reuse due to tightly coupled UI and game logic. |
| 🧪 | **Testing**       | No specific testing frameworks mentioned in the repository contents, potentially lacking automated testing coverage. |
| ⚡️  | **Performance**   | Basic game functionality without complex computations, likely efficient in resource usage on most systems. |
| 🛡️ | **Security**      | Basic security measures like resource metadata handling, but lacks explicit mention of security protocols or data protection mechanisms. |
| 📦 | **Dependencies**  | Relies on standard C# libraries and Windows Forms components, minimizing external dependencies. |
| 🚀 | **Scalability**   | Limited scalability due to monolithic code structure, may face challenges in handling increased complexity or feature additions. |

---

##  Repository Structure

```sh
└── FloppyyGame/
    ├── FloppGame
    │   ├── App.config
    │   ├── FloppGame.csproj
    │   ├── Form1.cs
    │   ├── Form1.Designer.cs
    │   ├── Form1.resx
    │   ├── MainMenu.cs
    │   ├── MainMenu.Designer.cs
    │   ├── MainMenu.dje-NE.resx
    │   ├── MainMenu.resx
    │   ├── Program.cs
    │   ├── Properties
    │   └── Resources
    └── FloppGame.sln
```

---

##  Modules

<details closed><summary>.</summary>

| File                                                                              | Summary                                                                                                                                                             |
| ---                                                                               | ---                                                                                                                                                                 |
| [FloppGame.sln](https://github.com/N0nettt/FloppyyGame/blob/master/FloppGame.sln) | Enables visualization and interaction with the game interface. Drives user experience in the FloppGame project by rendering forms and menus essential for gameplay. |

</details>

<details closed><summary>FloppGame</summary>

| File                                                                                                      | Summary                                                                                                                                                                                                                                                                                 |
| ---                                                                                                       | ---                                                                                                                                                                                                                                                                                     |
| [App.config](https://github.com/N0nettt/FloppyyGame/blob/master/FloppGame\App.config)                     | Configures the runtime environment for the FloppGame application within the parent repository. Specifies the supported.NET Framework version, enabling smooth execution.                                                                                                                |
| [FloppGame.csproj](https://github.com/N0nettt/FloppyyGame/blob/master/FloppGame\FloppGame.csproj)         | Defines project settings, dependencies, and resources for a C# Windows game application. Organizes compilation and resource files, specifying debug/release configurations, and referencing essential libraries for the games functionality within the parent repositorys architecture. |
| [Form1.cs](https://github.com/N0nettt/FloppyyGame/blob/master/FloppGame\Form1.cs)                         | Implements a side-scrolling game in C# with a bird navigating pipes. Determines gravity, pipe speed, and score tracking. Updates pipe positions, increases pipe speed with score, and ends game on collision.                                                                           |
| [Form1.Designer.cs](https://github.com/N0nettt/FloppyyGame/blob/master/FloppGame\Form1.Designer.cs)       | Implements the graphical user interface for the game, featuring bird and pipe visuals, game timer, and score display. Controls key events for game interactions.                                                                                                                        |
| [Form1.resx](https://github.com/N0nettt/FloppyyGame/blob/master/FloppGame\Form1.resx)                     | Defines resource metadata in a structured XML format, facilitating data type conversion and serialization. Supports storage of object configurations and settings for the parent FloppGame application.                                                                                 |
| [MainMenu.cs](https://github.com/N0nettt/FloppyyGame/blob/master/FloppGame\MainMenu.cs)                   | Implements main menu functionality for starting or quitting the game with hover effects. Manages font styles and event handlers for label interactions, ensuring smooth user experience. Provides options to start or exit the game with confirmation dialog.                           |
| [MainMenu.Designer.cs](https://github.com/N0nettt/FloppyyGame/blob/master/FloppGame\MainMenu.Designer.cs) | Defines Main Menu interface with Start and Quit options, handling mouse events. Provides visual elements and actions for users in a game application. Integrates with the main game logic for user interaction.                                                                         |
| [MainMenu.dje-NE.resx](https://github.com/N0nettt/FloppyyGame/blob/master/FloppGame\MainMenu.dje-NE.resx) | Defines metadata and resources for the FloppGame menu interface. Specifies formats for serializing objects and dependencies for reading. Supports storage and retrieval of menu-related data within the repository structure.                                                           |
| [MainMenu.resx](https://github.com/N0nettt/FloppyyGame/blob/master/FloppGame\MainMenu.resx)               | Defines resource metadata in XML format, specifying resource types and serialization methods for the parent repositorys localization and asset management. Facilitates seamless integration of resources into the projects UI components.                                               |
| [Program.cs](https://github.com/N0nettt/FloppyyGame/blob/master/FloppGame\Program.cs)                     | Initializes and launches the primary application form with visual styles and default text rendering settings in the Windows Forms-based FloppyyGame project.                                                                                                                            |

</details>

<details closed><summary>FloppGame.Properties</summary>

| File                                                                                                                   | Summary                                                                                                                                                                                                                                                        |
| ---                                                                                                                    | ---                                                                                                                                                                                                                                                            |
| [AssemblyInfo.cs](https://github.com/N0nettt/FloppyyGame/blob/master/FloppGame\Properties\AssemblyInfo.cs)             | Defines assembly metadata for FloppGame, specifying title, product, and version information. Controls assembly visibility to COM components. Critical for ensuring proper identification, configuration, and interoperability within the project architecture. |
| [Resources.Designer.cs](https://github.com/N0nettt/FloppyyGame/blob/master/FloppGame\Properties\Resources.Designer.cs) | Enables lookup of localized bitmap resources for game elements like birds, ground, and pipes. Facilitates easy retrieval of graphical assets to enhance the visual experience of the game interface.                                                           |
| [Resources.resx](https://github.com/N0nettt/FloppyyGame/blob/master/FloppGame\Properties\Resources.resx)               | Defines resources for the game UI, such as images and icons, facilitating easy access and management of visual assets within the main game application.                                                                                                        |
| [Settings.Designer.cs](https://github.com/N0nettt/FloppyyGame/blob/master/FloppGame\Properties\Settings.Designer.cs)   | Defines runtime settings for the FloppGame app. Ensures consistent configuration across the application. Optimizes development efficiency by centralizing settings handling.                                                                                   |
| [Settings.settings](https://github.com/N0nettt/FloppyyGame/blob/master/FloppGame\Properties\Settings.settings)         | Manages application configuration settings.** Stores user preferences and configurations for the FloppGame application. Key component for customizing user experience.                                                                                         |

</details>

---

##  Getting Started

**System Requirements:**

* **CSharp**: `version x.y.z`

###  Installation

<h4>From <code>source</code></h4>

> 1. Clone the FloppyyGame repository:
>
> ```console
> $ git clone https://github.com/N0nettt/FloppyyGame
> ```
>
> 2. Change to the project directory:
> ```console
> $ cd FloppyyGame
> ```
>
> 3. Install the dependencies:
> ```console
> $ dotnet build
> ```

###  Usage

<h4>From <code>source</code></h4>

> Run FloppyyGame using the command below:
> ```console
> $ dotnet run
> ```

###  Tests

> Run the test suite using the command below:
> ```console
> $ dotnet test
> ```

---

##  Project Roadmap

- [X] `► INSERT-TASK-1`
- [ ] `► INSERT-TASK-2`
- [ ] `► ...`

---

##  Contributing

Contributions are welcome! Here are several ways you can contribute:

- **[Report Issues](https://github.com/N0nettt/FloppyyGame/issues)**: Submit bugs found or log feature requests for the `FloppyyGame` project.
- **[Submit Pull Requests](https://github.com/N0nettt/FloppyyGame/blob/main/CONTRIBUTING.md)**: Review open PRs, and submit your own PRs.
- **[Join the Discussions](https://github.com/N0nettt/FloppyyGame/discussions)**: Share your insights, provide feedback, or ask questions.

<details closed>
<summary>Contributing Guidelines</summary>

1. **Fork the Repository**: Start by forking the project repository to your github account.
2. **Clone Locally**: Clone the forked repository to your local machine using a git client.
   ```sh
   git clone https://github.com/N0nettt/FloppyyGame
   ```
3. **Create a New Branch**: Always work on a new branch, giving it a descriptive name.
   ```sh
   git checkout -b new-feature-x
   ```
4. **Make Your Changes**: Develop and test your changes locally.
5. **Commit Your Changes**: Commit with a clear message describing your updates.
   ```sh
   git commit -m 'Implemented new feature x.'
   ```
6. **Push to github**: Push the changes to your forked repository.
   ```sh
   git push origin new-feature-x
   ```
7. **Submit a Pull Request**: Create a PR against the original project repository. Clearly describe the changes and their motivations.
8. **Review**: Once your PR is reviewed and approved, it will be merged into the main branch. Congratulations on your contribution!
</details>

<details closed>
<summary>Contributor Graph</summary>
<br>
<p align="center">
   <a href="https://github.com{/N0nettt/FloppyyGame/}graphs/contributors">
      <img src="https://contrib.rocks/image?repo=N0nettt/FloppyyGame">
   </a>
</p>
</details>

---

##  License

This project is protected under the [SELECT-A-LICENSE](https://choosealicense.com/licenses) License. For more details, refer to the [LICENSE](https://choosealicense.com/licenses/) file.

---

##  Acknowledgments

- List any resources, contributors, inspiration, etc. here.

[**Return**](#-overview)

---
