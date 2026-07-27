# Project contribution rules

## Application versioning

- The user-visible application version is defined in `src/KinoRezervacija.Web/AppVersion.cs`.
- Bump the application version for every commit that changes application code, tests, UI markup, styles, configuration, or other runtime behavior.
- Do not bump the application version for documentation-only commits.
- If a commit contains both documentation and code changes, bump the version.
- Keep the version visible in the application header and keep its format as `MAJOR.MINOR.PATCH`.
- Add or update a regression test when changing versioning behavior.

## Bug report feedback

- Preserve the original bug report, reproduction steps, and evidence.
- After fixing a bug, append a resolution note to the same report. Use the format `FIXED IN VERSION: #` with the actual application version, for example `FIXED IN VERSION: 0.1.0`.
- Mark the report as fixed only after the relevant automated checks and, when applicable, a live user-flow check pass.
- If a later change regresses the issue, append a new dated note instead of rewriting the original finding.

## Documentation language

- Project documentation, bug-report feedback, comments intended for users, and release notes must be written in Latvian or English.
- Keep the language consistent with the existing document when appending to it.
