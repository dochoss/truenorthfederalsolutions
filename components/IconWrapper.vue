<template>
  <div :class="iconWrapperClasses">
    <Icon :name="icon" :class="iconClasses" />
  </div>
</template>

<script setup>
// IconWrapper - Consistent icon presentation with background and colors
// Following the design system color palette and sizing

const props = defineProps({
  icon: {
    type: String,
    required: true
  },
  variant: {
    type: String,
    default: 'primary',
    validator: (value) => ['primary', 'secondary', 'success', 'warning', 'danger', 'accent'].includes(value)
  },
  size: {
    type: String,
    default: 'md',
    validator: (value) => ['sm', 'md', 'lg', 'xl'].includes(value)
  },
  shape: {
    type: String,
    default: 'rounded',
    validator: (value) => ['rounded', 'circle', 'square'].includes(value)
  }
})

const iconWrapperClasses = computed(() => {
  const baseClasses = ['flex', 'items-center', 'justify-center', 'flex-shrink-0']
  
  // Size variants
  const sizeClasses = {
    sm: ['w-8', 'h-8'],
    md: ['w-12', 'h-12'],
    lg: ['w-16', 'h-16'],
    xl: ['w-20', 'h-20']
  }
  
  // Shape variants
  const shapeClasses = {
    rounded: ['rounded-lg'],
    circle: ['rounded-full'],
    square: ['rounded-none']
  }
  
  // Color variants
  const variantClasses = {
    primary: ['bg-primary-100'],
    secondary: ['bg-secondary-100'],
    success: ['bg-success-100'],
    warning: ['bg-warning-100'],
    danger: ['bg-danger-100'],
    accent: ['bg-accent-100']
  }
  
  return [
    ...baseClasses,
    ...sizeClasses[props.size],
    ...shapeClasses[props.shape],
    ...variantClasses[props.variant]
  ]
})

const iconClasses = computed(() => {
  // Icon size mapping
  const iconSizeClasses = {
    sm: ['w-4', 'h-4'],
    md: ['w-6', 'h-6'],
    lg: ['w-8', 'h-8'],
    xl: ['w-10', 'h-10']
  }
  
  // Icon color variants
  const iconColorClasses = {
    primary: ['text-primary-700'],
    secondary: ['text-secondary-700'],
    success: ['text-success-700'],
    warning: ['text-warning-700'],
    danger: ['text-danger-700'],
    accent: ['text-accent-700']
  }
  
  return [
    ...iconSizeClasses[props.size],
    ...iconColorClasses[props.variant]
  ]
})
</script>