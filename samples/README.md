# Mosali Sainath Reddy — full-stack UI portfolio samples

Prepared October 27, 2026. New, illustrative samples for technical review; no client source code, client screenshots, production records, or affiliation with Iowa DOM DoIT is implied. Professional experience summaries are based on the supplied resume. These samples are intended for the candidate to review, understand, customize, and demonstrate.

## Contents

- `index.html` and `style.css`: complete responsive portfolio and demo shell.
- `samples/ui/app.js`: browser-local form validation/review, filtered case table, inline details, reusable feedback/disclosure patterns.
- `samples/ui/tokens.scss`: reference Sass tokens and focus-ring mixin. No Sass compilation is needed for the hosted site; matching CSS values are included in style.css.
- `samples/api/`: companion .NET 8 minimal API. It validates JSON input and deliberately stores nothing. The browser demos do not call this API.
- `samples/azure-pipelines.yml`: illustrative Azure DevOps pipeline, not a configured or executed deployment pipeline.

## Run the UI

Extract this archive, change to its root, and run `python3 -m http.server 8080`. Open http://localhost:8080. No package installation or build step is needed. The examples use native HTML/JavaScript, not Angular or React; the career section separately describes framework experience.

## Run the API

Install the .NET 8 SDK. From `samples/api`, run:

```
dotnet restore
dotnet build
dotnet run --urls http://localhost:5080
```

The HTTP URL is for local demonstration. Use HTTPS in hosted environments. `requests.http` contains valid and invalid requests for a compatible REST client. A successful request returns `valid: true` and `persisted: false`; invalid field values return a 400 validation-problem response. Malformed JSON is rejected by framework request binding. Do not enter real personal information.

This environment did not include the .NET SDK, so the API has not been compiled or executed here. It is a source example, not a deployed backend. The pipeline and Sass module have not been executed here.

## Architecture and scope

The UI keeps only transient state in memory. It makes no API calls and uses no browser storage. All sample records are fictional. Input is escaped before it is rendered in the review screen. Native required/email constraints are evaluated alongside explicit field errors; no client-side check replaces server-side validation.

A production implementation would require identity, authorization, durable SQL storage, abuse prevention, retention rules, secure hosting, telemetry redaction, and deployment review. Sensitive-data and encryption controls must be designed and validated for the actual environment; none are claimed by this demo. This portfolio does not demonstrate classified-data handling.

## Accessibility implementation and verification

Implemented: skip link, named navigation, semantic labels, required field semantics, linked inline errors, focusable error summary, focus movement at workflow transitions, text-based status indicators, live result counts/feedback, native select/disclosure controls, visible focus outlines, responsive grid breakpoints, table header associations, and reduced-motion support.

Verified in browser: empty-form validation and focus on the error summary; successful fictional input to review; completion state; case search narrowing to one record; inline case detail; preference feedback; and disclosure expansion. Native select keyboard navigation was exercised. Source JavaScript passed `node --check`. Desktop layout was visually inspected.

Not yet verified: full keyboard-only audit of every journey, JAWS/NVDA/VoiceOver behavior, automated axe audit, all WCAG 2.1 AA / Section 508 criteria, mobile devices, browser matrix, 200%/400% zoom, and formal contrast/target-size review. These are remaining checks, not completed evidence. No certification, formal accessibility training, or conformance guarantee is implied.

### Suggested reviewer walkthrough

1. Open the citizen application and submit empty fields. Follow an error link, correct fields, review, edit, then finish.
2. Open the caseworker workspace. Search Alex, inspect details, then try a search with no matches and clear it.
3. Combine a status filter with the search term. Confirm the result count and empty state.
4. Open Interface foundations. Save the sample preference, then toggle disclosure with keyboard.
5. Review the exact JavaScript, Sass reference, C# endpoint, and pipeline source.

## Enterprise design systems

The foundation demo illustrates tokens, reusable patterns, usage guidance, and behavior. A production enterprise system also needs ownership, versioning, contribution rules, accessibility acceptance criteria, documentation, and adoption across teams. Bootstrap and Material are UI frameworks/libraries; using them alone is not evidence of enterprise design-system experience.

## Role alignment and remaining evidence

The demos emphasize front-end implementation and UI behavior, with a separate C# validation sample. Professional summaries cover government/healthcare context, Angular/React modernization, APIs, and Azure DevOps. Formal WCAG training, JAWS experience, certification, enterprise design-system work history, and classified-data handling need the candidate's own verified evidence before being represented as qualifications. This sample does not itself satisfy those experience requirements.
