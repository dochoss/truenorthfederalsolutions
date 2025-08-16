# GitHub Copilot Instructions

This project is a template for Nuxt 3 projects using Tailwind CSS, Nuxt Tailwind module, NuxtIcon, and Nuxt Image. To ensure Copilot suggestions are consistent, modern, and leverage our stack, follow these guidelines:

---

## General Guidelines

- **Always use Nuxt 3 conventions**: Prefer Nuxt’s auto-imports, composables, and directory structure. See [Nuxt Auto Imports](https://nuxt.com/docs/guide/concepts/auto-imports).
- **Use Tailwind CSS for styling**: Do not use plain CSS or SCSS unless absolutely necessary. Reference [Tailwind CSS docs](https://tailwindcss.com/).
- **Configure Tailwind via Nuxt module**: Use the [Nuxt Tailwind module](https://nuxt.com/modules/tailwindcss) for all Tailwind configuration and integration.
- **Use NuxtIcon for icons**: Do not use HeroIcons directly. Always use the [NuxtIcon module](https://nuxt.com/modules/icon) for icon components.
- **Use Nuxt Image for images**: Prefer the [Nuxt Image module](https://nuxt.com/modules/image) for optimized images and responsive loading.

---

## Tone and style
You should be concise, direct, and to the point. When you run a non-trivial bash command, you should explain what the command does and why you are running it, to make sure the user understands what you are doing (this is especially important when you are running a command that will make changes to the user's system).
Remember that your output will be displayed on a command line interface. Your responses can use Github-flavored markdown for formatting, and will be rendered in a monospace font using the CommonMark specification.
Output text to communicate with the user; all text you output outside of tool use is displayed to the user. Only use tools to complete tasks. Never use tools like Bash or code comments as means to communicate with the user during the session.
If you cannot or will not help the user with something, please do not say why or what it could lead to, since this comes across as preachy and annoying. Please offer helpful alternatives if possible, and otherwise keep your response to 1-2 sentences.
IMPORTANT: You should minimize output tokens as much as possible while maintaining helpfulness, quality, and accuracy. Only address the specific query or task at hand, avoiding tangential information unless absolutely critical for completing the request. If you can answer in 1-3 sentences or a short paragraph, please do.
IMPORTANT: You should NOT answer with unnecessary preamble or postamble (such as explaining your code or summarizing your action), unless the user asks you to.
IMPORTANT: Keep your responses short, since they will be displayed on a command line interface. You MUST answer concisely with fewer than 4 lines (not including tool use or code generation), unless user asks for detail. Answer the user's question directly, without elaboration, explanation, or details. One word answers are best. Avoid introductions, conclusions, and explanations. You MUST avoid text before/after your response, such as "The answer is <answer>.", "Here is the content of the file..." or "Based on the information provided, the answer is..." or "Here is what I will do next...". Here are some examples to demonstrate appropriate verbosity:
<example>
user: 2 + 2
assistant: 4
</example>

<example>
user: what is 2+2?
assistant: 4
</example>

<example>
user: is 11 a prime number?
assistant: Yes
</example>

<example>
user: what command should I run to list files in the current directory?
assistant: ls
</example>

<example>
user: what command should I run to watch files in the current directory?
assistant: [use the ls tool to list the files in the current directory, then read docs/commands in the relevant file to find out how to watch files]
npm run dev
</example>

## Copilot-Specific Instructions

### Nuxt 3

- Use `<script setup>` syntax for all Vue components.
- Order components with `<template>`, `<script setup>`, and `<style>` blocks in that order.
- Use `NuxtLink` for internal navigation and `<a>` for external links.
- Use Nuxt’s auto-imported composables (e.g., `useRoute`, `useFetch`) instead of manual imports.
- Place pages in the `/pages` directory and components in `/components`.
- Use the `definePageMeta` and `defineNuxtComponent` helpers where appropriate.

### Tailwind CSS

- Use Tailwind utility classes for all styling.
- Do not suggest inline styles or CSS modules.
- Use the `@apply` directive in Tailwind for reusable class groups in component `<style>` blocks if needed.

### Nuxt Tailwind Module

- All Tailwind configuration should be in `tailwind.config.js` or via the Nuxt module options in `nuxt.config.ts`.
- Use module features like JIT mode and custom theme extensions as needed.

### NuxtIcon

- Use the `<Icon name="..." />` component for all icons.
- Do not use `<svg>` or external icon libraries directly.
- Reference the [NuxtIcon documentation](https://nuxt.com/modules/icon) for available icons and usage.

### Nuxt Image

- Use the `<NuxtImg>` component for all images.
- Prefer dynamic image sources and responsive attributes.
- Reference the [Nuxt Image documentation](https://nuxt.com/modules/image) for usage patterns.

---

## Example Usage

```vue
<template>
  <div class="p-8 bg-white rounded-lg shadow">
    <Icon name="heroicons-outline:home" class="w-6 h-6 text-blue-500" />
    <h1 class="text-2xl font-bold">Welcome</h1>
    <NuxtImg src="/images/example.jpg" width="400" height="300" class="rounded" />
  </div>
</template>

<script setup>
// No need to import Nuxt composables or components manually
</script>
```

---

## Task Management

- **Always reference TASKLIST.md**: Before starting work, check the task list for context and priorities.
- **Update task status**: Mark tasks as completed and add new tasks as they arise.
- **Document work performed**: Update the task list with a brief description of work completed.

## Additional Notes

- Always check the latest documentation for each module.
- Prefer composability and reusability in all code suggestions.
- Avoid suggesting deprecated APIs or patterns.

---

**References:**
- [Nuxt 3 Docs](https://nuxt.com/docs/guide/concepts/auto-imports)
- [Tailwind CSS Docs](https://tailwindcss.com/)
- [Nuxt Tailwind Module](https://nuxt.com/modules/tailwindcss)
- [NuxtIcon Module](https://nuxt.com/modules/icon)
- [Nuxt Image Module](https://nuxt.com/modules/image)