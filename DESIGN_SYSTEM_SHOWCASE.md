# Design System Showcase

This document demonstrates the True North Federal Solutions design system implementation and provides usage examples.

## Color Palette Demonstration

### Primary Colors (Brand Blue)
```vue
<div class="bg-primary-600 text-white p-4 rounded-lg">
  Primary 600 - Main brand color
</div>
<div class="bg-primary-700 text-white p-4 rounded-lg">
  Primary 700 - Dark brand color
</div>
```

### Secondary Colors (Professional Gray)
```vue
<div class="bg-secondary-600 text-white p-4 rounded-lg">
  Secondary 600 - Text color
</div>
<div class="text-secondary-600 p-4">
  Secondary 600 - Body text
</div>
```

### Accent Colors
```vue
<div class="bg-accent-500 text-white p-4 rounded-lg">
  Accent 500 - Gold for achievements
</div>
<div class="bg-success-500 text-white p-4 rounded-lg">
  Success 500 - Positive actions
</div>
<div class="bg-warning-500 text-white p-4 rounded-lg">
  Warning 500 - Important notices
</div>
<div class="bg-danger-500 text-white p-4 rounded-lg">
  Danger 500 - Errors and critical info
</div>
```

## Component Usage Examples

### BaseButton Component
```vue
<!-- Primary button -->
<BaseButton variant="primary" size="lg" icon-left="heroicons:phone">
  Schedule Consultation
</BaseButton>

<!-- Secondary button -->
<BaseButton variant="secondary" size="md" icon-right="heroicons:arrow-right">
  Learn More
</BaseButton>

<!-- Tertiary button -->
<BaseButton variant="tertiary" size="sm">
  Download
</BaseButton>

<!-- Danger button -->
<BaseButton variant="danger" size="md">
  Delete Account
</BaseButton>
```

### BaseCard Component
```vue
<!-- Basic card -->
<BaseCard padding="md">
  <h3 class="text-lg font-semibold">Card Title</h3>
  <p class="text-secondary-600">Card content goes here.</p>
</BaseCard>

<!-- Interactive card with header and footer -->
<BaseCard interactive variant="elevated" title="Federal Contract Setup">
  <template #header>
    <IconWrapper icon="heroicons:document-text" variant="primary" size="md" />
  </template>
  
  <p class="text-secondary-600">
    Get your business ready for federal contracting.
  </p>
  
  <template #footer>
    <BaseButton variant="primary" full-width>
      Get Started
    </BaseButton>
  </template>
</BaseCard>
```

### BaseSection Component
```vue
<!-- Section with title and subtitle -->
<BaseSection 
  title="Our Services" 
  subtitle="Comprehensive federal contracting support"
  variant="default"
  spacing="lg"
>
  <!-- Section content -->
  <div class="grid grid-cols-1 md:grid-cols-3 gap-8">
    <!-- Grid content -->
  </div>
</BaseSection>

<!-- Primary variant section -->
<BaseSection variant="primary" spacing="xl" centered>
  <template #header>
    <h1 class="text-4xl font-bold text-white">
      Ready to Get Started?
    </h1>
  </template>
  
  <BaseButton variant="secondary" size="lg">
    Contact Us
  </BaseButton>
</BaseSection>
```

### IconWrapper Component
```vue
<!-- Different variants and sizes -->
<IconWrapper icon="heroicons:briefcase" variant="primary" size="lg" />
<IconWrapper icon="heroicons:shield-check" variant="success" size="md" />
<IconWrapper icon="heroicons:exclamation-triangle" variant="warning" size="sm" />
<IconWrapper icon="heroicons:academic-cap" variant="accent" size="xl" shape="circle" />
```

### FormInput Component
```vue
<!-- Basic input -->
<FormInput 
  v-model="email" 
  type="email" 
  label="Email Address" 
  placeholder="Enter your email"
  hint="We'll never share your email address"
/>

<!-- Input with icons -->
<FormInput 
  v-model="search" 
  type="text" 
  label="Search" 
  placeholder="Search resources..."
  icon-left="heroicons:magnifying-glass"
/>

<!-- Input with error state -->
<FormInput 
  v-model="name" 
  type="text" 
  label="Full Name" 
  placeholder="Enter your full name"
  required
  error="This field is required"
/>
```

## Layout Patterns

### Standard Page Layout
```vue
<template>
  <div>
    <NavSection />
    
    <!-- Hero section -->
    <BaseSection variant="primary" spacing="xl" centered>
      <!-- Hero content -->
    </BaseSection>
    
    <!-- Content sections -->
    <BaseSection title="Section Title" subtitle="Section subtitle" spacing="lg">
      <!-- Section content -->
    </BaseSection>
    
    <!-- CTA section -->
    <BaseSection variant="primary" spacing="lg" centered>
      <!-- Call to action content -->
    </BaseSection>
    
    <FooterSection />
  </div>
</template>
```

### Service Cards Grid
```vue
<div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-8">
  <BaseCard interactive padding="md" class="hover:shadow-medium transition-shadow">
    <div class="text-center">
      <IconWrapper 
        icon="heroicons:document-text" 
        variant="primary" 
        size="lg" 
        class="mx-auto mb-6"
      />
      <h3 class="text-xl font-bold text-secondary-900 mb-4">Service Title</h3>
      <p class="text-secondary-600 mb-6">Service description.</p>
      <BaseButton variant="tertiary" icon-right="heroicons:arrow-right">
        Learn More
      </BaseButton>
    </div>
  </BaseCard>
</div>
```

## Federal Contracting Specific Features

### Trust Indicators
```vue
<div class="grid grid-cols-1 md:grid-cols-3 gap-8">
  <div class="text-center">
    <IconWrapper icon="heroicons:star" variant="accent" size="lg" class="mx-auto mb-4" />
    <h3 class="text-2xl font-bold text-secondary-900 mb-2">15+ Years</h3>
    <p class="text-secondary-600">Federal service experience</p>
  </div>
</div>
```

### Process Steps
```vue
<div class="grid grid-cols-1 md:grid-cols-4 gap-8">
  <div class="text-center">
    <div class="flex items-center justify-center w-16 h-16 bg-primary-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
      1
    </div>
    <h3 class="text-lg font-semibold text-secondary-900 mb-3">Assessment</h3>
    <p class="text-secondary-600 text-sm">Step description</p>
  </div>
</div>
```

## Responsive Design

The design system is built mobile-first with responsive breakpoints:

- **Mobile**: < 640px (sm)
- **Tablet**: 640px - 1024px (md-lg)
- **Desktop**: > 1024px (xl)

### Responsive Grid Example
```vue
<div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 xl:grid-cols-4 gap-4 md:gap-6 lg:gap-8">
  <!-- Grid items -->
</div>
```

### Responsive Typography
```vue
<h1 class="text-2xl md:text-3xl lg:text-4xl xl:text-5xl font-bold">
  Responsive Heading
</h1>
```

## Best Practices

1. **Consistency**: Always use design system components instead of custom styling
2. **Accessibility**: Form components include proper labels and ARIA attributes
3. **Performance**: Components are optimized for tree-shaking and minimal bundle size
4. **Maintainability**: All styling is centralized in the Tailwind config and components
5. **Federal Context**: Colors and messaging appropriate for government contracting industry

## Implementation Notes

- All components are auto-imported by Nuxt 3
- Design tokens are defined in `tailwind.config.js`
- Component library supports theming through Tailwind CSS variables
- Icons use Heroicons for consistency
- Typography uses Inter font for modern, professional appearance