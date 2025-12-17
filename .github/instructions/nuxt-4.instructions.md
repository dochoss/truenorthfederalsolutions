---
description: "This instruction provides comprehensive guidance for Nuxt 4 development with Nuxt UI v4+, covering code organization, performance, security, testing, and common pitfalls. It helps developers build robust, scalable, and maintainable Nuxt 4 applications by adhering to community-accepted best practices and coding standards."
applyTo: "*.js,*.jsx,*.ts,*.tsx,*.vue"
---
# Nuxt 4 Best Practices with Nuxt UI

This document outlines best practices for developing Nuxt 4 applications with Nuxt UI v4+, focusing on code organization, performance optimization, security, testing strategies, and common pitfalls to avoid.

## 1. Code Organization and Structure

### Directory Structure (Nuxt 4)

Nuxt 4 introduces a new `app/` directory structure for better organization:

*   **`app/`**: Main application directory
    *   `pages/`: Page components that automatically become routes
    *   `components/`: Auto-imported reusable Vue components
    *   `composables/`: Auto-imported Vue composables and utility functions
    *   `layouts/`: Layout components that wrap pages
    *   `middleware/`: Route middleware for navigation guards
    *   `plugins/`: Plugins to extend Vue or add global functionality
    *   `utils/`: Auto-imported utility functions
    *   `assets/`: Assets processed by the build tool (CSS, images)
    *   `app.vue`: Root component
    *   `app.config.ts`: Runtime application configuration
*   **`server/`**: Server-side functionality powered by Nitro
    *   `api/`: API routes (`server/api/users.ts` → `/api/users`)
    *   `middleware/`: Server middleware
*   **`public/`**: Static assets served directly
*   **`nuxt.config.ts`**: Nuxt configuration file

### File Naming Conventions

*   **Components:** `ComponentName.vue` (PascalCase)
*   **Pages:** `kebab-case.vue` or `index.vue`
*   **Layouts:** `kebab-case.vue` or `default.vue`
*   **Composables:** `useComposableName.ts`
*   **Utils:** `utilityName.ts`
*   **Middleware:** `middleware-name.ts`
*   **API Routes:** `route-name.ts` or `[param].ts`

### Component Architecture

*   **Use `<script setup>` syntax:** Modern composition API approach for all components
*   **Wrap app with `<UApp>`:** Required for Nuxt UI global features (Toast, Tooltip, Overlays)
*   **Server Components by default:** Leverage server-side rendering for better performance
*   **Client Components when needed:** Use `.client.vue` suffix for client-only components
*   **Lazy Loading:** Use `Lazy` prefix for components that should load on demand
*   **Auto-imports:** Take advantage of Nuxt's auto-import system
*   **definePageMeta:** Use for page-specific configuration and metadata

## 2. Nuxt UI v4+ Integration

### Setup Requirements

```typescript
// nuxt.config.ts
export default defineNuxtConfig({
  modules: ['@nuxt/ui'],
  css: ['~/assets/css/main.css']
})
```

```css
/* app/assets/css/main.css */
@import "tailwindcss";
@import "@nuxt/ui";
```

```vue
<!-- app/app.vue -->
<template>
  <UApp>
    <NuxtPage />
  </UApp>
</template>
```

### Component Usage

*   **Component Prefix:** All Nuxt UI components use `U` prefix (e.g., `<UButton>`, `<UCard>`)
*   **Auto-imports:** Components are automatically imported, no manual imports needed
*   **Semantic Colors:** Use color props like `primary`, `secondary`, `success`, `info`, `warning`, `error`, `neutral`

```vue
<template>
  <UButton color="primary" variant="solid">Save</UButton>
  <UCard>
    <template #header>Title</template>
    Content here
    <template #footer>Footer</template>
  </UCard>
</template>
```

### Theme Configuration

Configure component themes globally via `app.config.ts`:

```typescript
// app.config.ts
export default defineAppConfig({
  ui: {
    colors: {
      primary: 'blue',
      secondary: 'purple',
      neutral: 'zinc'
    },
    button: {
      slots: {
        base: 'font-bold'
      },
      defaultVariants: {
        color: 'neutral'
      }
    }
  }
})
```

### Per-Component Customization

Use the `ui` prop for slot-specific styling:

```vue
<template>
  <UButton 
    :ui="{ base: 'rounded-full' }"
    class="my-custom-class"
  >
    Custom Button
  </UButton>
</template>
```

## 3. Tailwind CSS v4 Integration

### CSS-First Configuration

Tailwind CSS v4 uses CSS-first configuration with the `@theme` directive:

```css
/* app/assets/css/main.css */
@import "tailwindcss";
@import "@nuxt/ui";

@theme {
  --font-sans: 'Public Sans', system-ui, sans-serif;
  --font-mono: 'JetBrains Mono', monospace;
}

@theme static {
  /* Custom colors */
  --color-brand-50: #f0f9ff;
  --color-brand-500: #3b82f6;
  --color-brand-950: #172554;
}
```

### CSS Variables for Theming

```css
:root {
  --ui-primary: var(--color-blue-500);
  --ui-radius: 0.5rem;
  --ui-container: var(--container-5xl);
  --ui-header-height: var(--spacing-24);
}

.dark {
  --ui-primary: var(--color-blue-400);
  --ui-bg: var(--color-neutral-950);
}
```

### Semantic Utility Classes

Use Nuxt UI's semantic utility classes:

*   **Text:** `text-primary`, `text-dimmed`, `text-muted`, `text-highlighted`
*   **Background:** `bg-default`, `bg-elevated`, `bg-accented`
*   **Border:** `border-default`, `border-muted`

## 4. Common Patterns and Anti-patterns

### Recommended Approaches

*   **Data fetching:** Use `useFetch`, `useAsyncData`, or `$fetch` for data fetching
*   **State management:** Use `useState` for SSR-compatible reactive state, or Pinia for complex state
*   **Forms:** Use Nuxt UI form components (`<UInput>`, `<USelect>`, `<UForm>`)
*   **Error handling:** Use `NuxtErrorBoundary` and `error.vue` pages
*   **SEO:** Use `useHead`, `useSeoMeta`, or `definePageMeta` for meta tags
*   **Icons:** Use `<Icon name="heroicons:home" />` from @nuxt/icon

### Anti-patterns to Avoid

*   **Not wrapping app with `<UApp>`:** Required for Toast, Tooltip, and programmatic overlays
*   **Using `$fetch` without `useAsyncData`:** Causes double data fetching (server + client)
*   **Not using auto-imports:** Manually importing what Nuxt provides automatically
*   **Overusing useState:** For simple local state, use regular `ref` or `reactive`
*   **Ignoring hydration:** Not considering server-client differences
*   **Using old Tailwind config:** Use CSS-first `@theme` directive instead of `tailwind.config.js`

## 5. Performance Considerations

### Optimization Techniques

*   **Image optimization:** Use `<NuxtImg>` and `<NuxtPicture>` for automatic optimization
*   **Font optimization:** Fonts defined in `@theme` are auto-loaded by `@nuxt/fonts`
*   **Lazy loading:** Use `Lazy` prefix for components
*   **Component detection:** Enable `experimental.componentDetection` for tree-shaking

```typescript
// nuxt.config.ts
export default defineNuxtConfig({
  ui: {
    experimental: {
      componentDetection: true
    }
  }
})
```

### Rendering Optimization

*   **Universal Rendering:** Get fast first load (SSR) + fast navigation (SPA)
*   **Static Generation:** Use `nuxt generate` for static content
*   **Hybrid Rendering:** Mix SSR and static generation with ISR

## 6. Built-in Composables

### Nuxt Core Composables

*   **`useHead`:** Manage document head reactively
*   **`useSeoMeta`:** Server-optimized SEO meta tags
*   **`useRoute`:** Access current route information
*   **`useRouter`:** Navigate programmatically
*   **`useState`:** SSR-friendly global state
*   **`useCookie`:** Manage cookies reactively
*   **`useRuntimeConfig`:** Access runtime configuration

### Data Fetching Composables

*   **`useFetch`:** Simple HTTP requests with caching
*   **`useAsyncData`:** Advanced data fetching with custom logic
*   **`useLazyFetch`:** Non-blocking data fetching
*   **`$fetch`:** Programmatic HTTP requests (wrap with useAsyncData for SSR)

## 7. Nuxt UI Component Categories

### Layout Components

*   `<UApp>`: Root wrapper for global features
*   `<UContainer>`: Responsive container
*   `<UCard>`: Card with header/footer slots
*   `<UDivider>`: Visual separator

### Form Components

*   `<UForm>`: Form wrapper with validation
*   `<UInput>`: Text input
*   `<UTextarea>`: Multi-line input
*   `<USelect>`: Dropdown select
*   `<UCheckbox>`: Checkbox input
*   `<URadio>`: Radio button
*   `<UToggle>`: Toggle switch

### Navigation Components

*   `<UNavigationMenu>`: Navigation menu
*   `<UTabs>`: Tab navigation
*   `<UBreadcrumb>`: Breadcrumb navigation
*   `<UPagination>`: Pagination controls

### Overlay Components

*   `<UModal>`: Modal dialog
*   `<UDrawer>`: Side drawer
*   `<UPopover>`: Popover
*   `<UTooltip>`: Tooltip
*   `<UDropdown>`: Dropdown menu

### Feedback Components

*   `<UToast>`: Toast notifications (use `useToast()`)
*   `<UAlert>`: Alert messages
*   `<UBadge>`: Status badges
*   `<UProgress>`: Progress indicators

### Data Display

*   `<UTable>`: Data table
*   `<UAvatar>`: User avatars
*   `<UIcon>`: Icons (via @nuxt/icon)

## 8. VS Code Configuration

Add these settings for Tailwind CSS IntelliSense:

```json
// .vscode/settings.json
{
  "files.associations": {
    "*.css": "tailwindcss"
  },
  "editor.quickSuggestions": {
    "strings": "on"
  },
  "tailwindCSS.classAttributes": ["class", "ui"],
  "tailwindCSS.experimental.classRegex": [
    ["ui:\\s*{([^)]*)\\s*}", "(?:'|\"|`)([^']*)(?:'|\"|`)"]
  ]
}
```

## 9. Security Best Practices

*   **Server-side validation:** Always validate input in API routes
*   **Environment variables:** Use `.env` files and `runtimeConfig` for secrets
*   **HTTPS enforcement:** Always use HTTPS in production
*   **Secure headers:** Configure security headers in Nuxt config
*   **CSRF Protection:** Implement CSRF tokens for forms and API calls

## 10. Testing Approaches

*   **Component testing:** Use `@nuxt/test-utils` with Vitest
*   **E2E testing:** Use Cypress or Playwright for end-to-end tests
*   **API testing:** Test server routes and middleware

## 11. Deployment

*   **GitHub Pages:** For static sites with `nuxt generate`
*   **Vercel/Netlify:** Zero-config deployment with edge functions
*   **Node.js server:** Use `nuxt build` for SSR deployment
*   **Docker:** Containerized deployment

## References

- [Nuxt 4 Docs](https://nuxt.com/docs/4.x/getting-started/introduction)
- [Nuxt UI Docs](https://ui.nuxt.com/)
- [Tailwind CSS Docs](https://tailwindcss.com/)
- [Nuxt Icon Module](https://nuxt.com/modules/icon)
- [Nuxt Image Module](https://nuxt.com/modules/image)
