# True North Federal Solutions - Design System

This document outlines the design system for True North Federal Solutions, ensuring consistent and professional presentation across all digital touchpoints.

## Brand Overview

True North Federal Solutions specializes in federal contracting consulting, helping small businesses navigate the complex world of government procurement. The design system reflects professionalism, trustworthiness, and expertise required in the federal contracting space.

## Color System

### Primary Colors
- **Primary 600** (`primary-600`): `#2563eb` - Main brand blue for primary actions, headers
- **Primary 700** (`primary-700`): `#1d4ed8` - Dark blue for hover states, emphasis
- **Primary 500** (`primary-500`): `#3b82f6` - Light blue for accents, backgrounds

### Secondary Colors
- **Secondary 600** (`secondary-600`): `#475569` - Professional gray for text
- **Secondary 700** (`secondary-700`): `#334155` - Dark gray for emphasis
- **Secondary 500** (`secondary-500`): `#64748b` - Medium gray for secondary text

### Accent Colors
- **Success** (`success-500`): `#22c55e` - Success states, positive feedback
- **Warning** (`warning-500`): `#eab308` - Warnings, important notices
- **Danger** (`danger-500`): `#ef4444` - Errors, critical information
- **Accent** (`accent-500`): `#fbbf24` - Gold for achievements, certifications

## Typography

### Font Families
- **Primary**: Inter (system fallback: system-ui, sans-serif)
- **Serif**: Merriweather (for emphasis or special content)

### Typography Scale
- **Display**: `text-5xl` (48px) - Hero headings
- **H1**: `text-4xl` (36px) - Page titles
- **H2**: `text-3xl` (30px) - Section headers
- **H3**: `text-2xl` (24px) - Subsection headers
- **H4**: `text-xl` (20px) - Component headers
- **Body**: `text-base` (16px) - Regular text
- **Small**: `text-sm` (14px) - Captions, labels
- **XS**: `text-xs` (12px) - Fine print

## Spacing System

### Base Unit: 4px (Tailwind's default)
- **xs**: `space-1` (4px)
- **sm**: `space-2` (8px)
- **md**: `space-4` (16px)
- **lg**: `space-6` (24px)
- **xl**: `space-8` (32px)
- **2xl**: `space-12` (48px)
- **3xl**: `space-16` (64px)

## Component Patterns

### Buttons
- **Primary**: Blue background, white text, rounded medium
- **Secondary**: White background, blue border and text
- **Tertiary**: No background, blue text only
- **Danger**: Red background for destructive actions

### Cards
- **Soft shadow**: For content cards
- **Medium shadow**: For interactive cards
- **Strong shadow**: For modal overlays

### Layout
- **Container**: `max-w-7xl mx-auto px-4 sm:px-6 lg:px-8`
- **Section spacing**: `py-16` for main sections
- **Component spacing**: `py-8` for smaller sections

## Icon System

### Primary Icon Set: Heroicons
- Consistent style and weight
- Outline style for most UI elements
- Solid style for filled states or emphasis

### Common Icon Sizes
- **Small**: `w-4 h-4` (16px)
- **Medium**: `w-6 h-6` (24px)
- **Large**: `w-8 h-8` (32px)
- **XL**: `w-12 h-12` (48px)

## Responsive Design

### Breakpoints
- **Mobile**: `< 640px`
- **Tablet**: `640px - 1024px`
- **Desktop**: `> 1024px`

### Mobile-First Approach
- Design for mobile first
- Progressive enhancement for larger screens
- Touch-friendly interactive elements (minimum 44px touch targets)

## Animation & Transitions

### Standard Transitions
- **Colors**: `transition-colors` (150ms)
- **Shadows**: `transition-shadow` (150ms)
- **Transform**: `transition-transform` (150ms)

### Custom Animations
- **Fade In**: For content loading
- **Slide Up**: For modal appearance
- **Slide Down**: For dropdown menus

## Federal Contracting Specific Guidelines

### Professional Tone
- Use professional, authoritative language
- Emphasize expertise and experience
- Include relevant certifications and credentials

### Trust Indicators
- Display years of experience
- Highlight government service background
- Show certifications and qualifications

### Color Psychology
- Blue conveys trust, reliability, professionalism
- Gold accents suggest achievement and excellence
- Conservative color palette appropriate for government sector

## Usage Guidelines

### Do's
- Use consistent spacing throughout the application
- Follow the established color hierarchy
- Maintain consistent typography scales
- Use icons consistently from the Heroicons set
- Apply shadows appropriately to establish hierarchy

### Don'ts
- Don't use colors outside the defined palette
- Don't mix font families unnecessarily
- Don't use inconsistent spacing values
- Don't mix icon styles (outline vs solid) in the same context
- Don't apply animations to critical business functions

## Component Library Reference

See the `/components` directory for implementation examples of:
- `BaseButton.vue` - Standard button components
- `BaseCard.vue` - Card layout components
- `UPageSection.vue` - Section wrapper components
- `BaseModal.vue` - Modal and overlay components
- `FormInput.vue` - Form input components
- `IconButton.vue` - Icon-only button components

## Implementation Notes

This design system is implemented using:
- **Tailwind CSS** for utility-first styling
- **Custom Tailwind configuration** for brand colors and tokens
- **Vue 3 Composition API** for component logic
- **Nuxt 3** for application framework and auto-imports