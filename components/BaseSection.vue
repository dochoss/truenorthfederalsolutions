<template>
  <section :class="sectionClasses">
    <div :class="containerClasses">
      <!-- Section Header -->
      <div v-if="$slots.header || title || subtitle" :class="headerClasses">
        <slot name="header">
          <div class="text-center">
            <h2 v-if="title" :class="titleClasses">
              {{ title }}
            </h2>
            <p v-if="subtitle" :class="subtitleClasses">
              {{ subtitle }}
            </p>
          </div>
        </slot>
      </div>
      
      <!-- Section Content -->
      <div :class="contentClasses">
        <slot />
      </div>
      
      <!-- Section Footer -->
      <div v-if="$slots.footer" :class="footerClasses">
        <slot name="footer" />
      </div>
    </div>
  </section>
</template>

<script setup>
// BaseSection - Core section wrapper component following the design system
// Provides consistent spacing, container widths, and layout patterns

const props = defineProps({
  // Visual variants
  variant: {
    type: String,
    default: 'default',
    validator: (value) => ['default', 'primary', 'secondary', 'accent'].includes(value)
  },
  
  // Spacing options
  spacing: {
    type: String,
    default: 'lg',
    validator: (value) => ['sm', 'md', 'lg', 'xl'].includes(value)
  },
  
  // Container width
  container: {
    type: String,
    default: '7xl',
    validator: (value) => ['full', '4xl', '5xl', '6xl', '7xl'].includes(value)
  },
  
  // Content layout
  centered: {
    type: Boolean,
    default: false
  },
  
  // Header content
  title: {
    type: String,
    default: null
  },
  subtitle: {
    type: String,
    default: null
  },
  
  // Header spacing
  headerSpacing: {
    type: String,
    default: 'lg',
    validator: (value) => ['sm', 'md', 'lg', 'xl'].includes(value)
  }
})

const sectionClasses = computed(() => {
  const baseClasses = []
  
  // Spacing variants
  const spacingClasses = {
    sm: ['py-8'],
    md: ['py-12'],
    lg: ['py-16'],
    xl: ['py-24']
  }
  
  // Background variants
  const variantClasses = {
    default: ['bg-white'],
    primary: ['bg-primary-600', 'text-white'],
    secondary: ['bg-secondary-50'],
    accent: ['bg-accent-50']
  }
  
  // Defensive prop access with fallbacks
  const spacing = props?.spacing || 'lg'
  const variant = props?.variant || 'default'
  
  // Ensure we always get arrays
  const spacingClass = spacingClasses[spacing] || spacingClasses.lg || []
  const variantClass = variantClasses[variant] || variantClasses.default || []
  
  return [
    ...baseClasses,
    ...spacingClass,
    ...variantClass
  ]
})

const containerClasses = computed(() => {
  const baseClasses = ['mx-auto', 'px-4', 'sm:px-6', 'lg:px-8']
  
  const widthClasses = {
    full: ['w-full'],
    '4xl': ['max-w-4xl'],
    '5xl': ['max-w-5xl'],
    '6xl': ['max-w-6xl'],
    '7xl': ['max-w-7xl']
  }
  
  // Defensive prop access with fallback
  const container = props?.container || '7xl'
  const widthClass = widthClasses[container] || widthClasses['7xl'] || []
  
  return [...baseClasses, ...widthClass]
})

const headerClasses = computed(() => {
  const spacingClasses = {
    sm: ['mb-6'],
    md: ['mb-8'],
    lg: ['mb-12'],
    xl: ['mb-16']
  }
  
  // Defensive prop access with fallback
  const headerSpacing = props?.headerSpacing || 'lg'
  const spacingClass = spacingClasses[headerSpacing] || spacingClasses.lg || []
  
  return spacingClass
})

const titleClasses = computed(() => {
  const baseClasses = ['font-bold', 'text-secondary-900']
  
  // Adjust text color for variants
  if (props.variant === 'primary') {
    baseClasses.splice(-1, 1, 'text-white')
  }
  
  return [...baseClasses, 'text-3xl', 'mb-4']
})

const subtitleClasses = computed(() => {
  const baseClasses = ['text-lg', 'max-w-2xl', 'mx-auto']
  
  // Adjust text color for variants
  if (props.variant === 'primary') {
    baseClasses.push('text-primary-100')
  } else {
    baseClasses.push('text-secondary-600')
  }
  
  return baseClasses
})

const contentClasses = computed(() => {
  const classes = []
  
  if (props.centered) {
    classes.push('text-center')
  }
  
  return classes
})

const footerClasses = computed(() => {
  return ['mt-8', 'pt-8']
})
</script>