<template>
  <button
    :class="buttonClasses"
    :disabled="disabled"
    :type="type"
    @click="$emit('click', $event)"
  >
    <Icon v-if="iconLeft" :name="iconLeft" :class="iconClasses" />
    <slot />
    <Icon v-if="iconRight" :name="iconRight" :class="iconClasses" />
  </button>
</template>

<script setup>
// BaseButton - Core button component following the design system
// Supports multiple variants, sizes, and states

const props = defineProps({
  variant: {
    type: String,
    default: 'primary',
    validator: (value) => ['primary', 'secondary', 'tertiary', 'danger'].includes(value)
  },
  size: {
    type: String,
    default: 'md',
    validator: (value) => ['sm', 'md', 'lg'].includes(value)
  },
  disabled: {
    type: Boolean,
    default: false
  },
  type: {
    type: String,
    default: 'button'
  },
  iconLeft: {
    type: String,
    default: null
  },
  iconRight: {
    type: String,
    default: null
  },
  fullWidth: {
    type: Boolean,
    default: false
  }
})

defineEmits(['click'])

// Computed classes based on props
const buttonClasses = computed(() => {
  const baseClasses = [
    'inline-flex',
    'items-center',
    'justify-center',
    'font-medium',
    'rounded-md',
    'transition-colors',
    'focus:outline-none',
    'focus:ring-2',
    'focus:ring-offset-2',
    'disabled:opacity-50',
    'disabled:cursor-not-allowed'
  ]

  // Full width
  if (props.fullWidth) {
    baseClasses.push('w-full')
  }

  // Size variants
  const sizeClasses = {
    sm: ['px-3', 'py-1.5', 'text-sm'],
    md: ['px-4', 'py-2', 'text-base'],
    lg: ['px-6', 'py-3', 'text-lg']
  }

  // Color variants
  const variantClasses = {
    primary: [
      'bg-primary-600',
      'text-white',
      'hover:bg-primary-700',
      'focus:ring-primary-500',
      'disabled:bg-primary-300'
    ],
    secondary: [
      'bg-white',
      'text-primary-600',
      'border',
      'border-primary-600',
      'hover:bg-primary-50',
      'focus:ring-primary-500',
      'disabled:border-primary-300',
      'disabled:text-primary-300'
    ],
    tertiary: [
      'bg-transparent',
      'text-primary-600',
      'hover:bg-primary-50',
      'focus:ring-primary-500',
      'disabled:text-primary-300'
    ],
    danger: [
      'bg-danger-500',
      'text-white',
      'hover:bg-danger-600',
      'focus:ring-danger-400',
      'disabled:bg-danger-300'
    ]
  }

  // Defensive prop access with fallbacks
  const size = props?.size || 'md'
  const variant = props?.variant || 'primary'
  
  // Ensure we always get arrays
  const sizeClass = sizeClasses[size] || sizeClasses.md || []
  const variantClass = variantClasses[variant] || variantClasses.primary || []

  return [
    ...baseClasses,
    ...sizeClass,
    ...variantClass
  ]
})

const iconClasses = computed(() => {
  const sizeMap = {
    sm: 'w-4 h-4',
    md: 'w-5 h-5',
    lg: 'w-6 h-6'
  }
  
  // Defensive prop access with fallback
  const size = props?.size || 'md'
  const sizeClass = sizeMap[size] || sizeMap.md || ''
  
  const classes = [sizeClass]
  
  // Add spacing based on slot content
  if (props.iconLeft) {
    classes.push('mr-2')
  }
  if (props.iconRight) {
    classes.push('ml-2')
  }
  
  return classes
})
</script>