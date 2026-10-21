# GitHub Copilot Instructions for Quality And Durability (Continued)

## Mod Overview and Purpose

The "Quality And Durability (Continued)" mod is an update of the original mod created by Amnabi. It enhances the gameplay of RimWorld by introducing a system where the quality of weapons and armor directly affects their maximum hit points. This mod allows players to have more strategic depth in managing their gear, as the quality multiplier can be adjusted via mod-settings.

## Key Features and Systems

- **Quality Impact on Durability**: Introduces a mechanic where the quality of weapons and armor impacts their durability and max hit points.
- **Mod Settings**: Provides mod-settings to customize the quality multipliers, allowing for fine-tuning gameplay experience.
- **Improved Error Reporting**: Encourages players to use a dedicated Discord channel for error reporting and the use of the Log Uploader for better support.
- **Compatibility Checks**: Recommends using RimSort to sort mods and guides players through testing mod compatibility.

## Coding Patterns and Conventions

### C# Files and Types

The mod is structured with several C# files, each focusing on particular components of the mod:

1. **CompQuality_SetQuality.cs**: Deals with setting quality specifically for component-based logic.
   - Member: `Postfix`
   
2. **Harmony_QualityAndDurability.cs**: Integrates Harmony patches for overriding or extending game behavior.
   - Members: `AdjustSwitch`, `Harmony_QualityAndDurability`

3. **QualityAndDurabilityMod.cs**: Main entry for defining mod-specific behaviors and settings.
   - Members: `DoSettingsWindowContents`, `QualityAndDurabilityMod`, `Settings`, `SettingsCategory`

4. **QualityAndDurabilitySettings.cs**: Handles custom settings storage and exposure.
   - Member: `ExposeData`
   
5. **Thing_MaxHitPoints.cs**: Alters the max hit points logic for items based on quality.
   - Member: `Postfix`

### XML Integration

The mod uses a single XML file (`About.xml`) for describing mod metadata and its dependencies, specifically on `brrainz.harmony`. No XML defs are used, emphasizing the mod's reliance on C# for dynamic behavior modification.

## Harmony Patching

Harmony is used to apply patches to the game’s methods, thereby modifying or extending them without changing the game’s source code directly. This mod uses Harmony to:

- Apply a postfix on item creation ensuring quality impacts max hit points correctly.
- Handle custom logic adjustments via `AdjustSwitch` method.

Utilize `Harmony_QualityAndDurability` to manage and organize these patches, ensuring they are cleanly applied and removed.

## Suggestions for Copilot

When using GitHub Copilot for this project, consider the following suggestions:

- **Pattern Recognition**: Encourage Copilot to recognize the module patterns and suggest similar patterns for new feature extensions or debugging.
- **XML File Processing**: Assists in managing dependencies and ensures the XML files are consistent with RimWorld modding standards.
- **Code Commenting**: Assist with generating meaningful comments for patches, explaining the reasoning for specific game changes.
- **Harmony Methods**: Generate boilerplate for new Harmony patches, specifically focusing on postfixes, given the project’s structure.

## Final Note

This mod improves player experience by integrating quality-based logic in a structured manner. It is crucial for contributors to adhere to these guidelines to maintain consistency and functionality across updates.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

