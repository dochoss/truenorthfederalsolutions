<template>
  <div :class="cardClasses">
    <div v-if="$slots.header || title" class="px-6 py-4 border-b border-secondary-200">
      <slot name="header">
        <h3 v-if="title" class="text-lg font-semibold text-secondary-900">
          {{ title }}
        </h3>
      </slot>
    </div>
    
    <div :class="contentClasses">
      <slot />
    </div>
    
    <div v-if="$slots.footer" class="px-6 py-4 border-t border-secondary-200 bg-secondary-50">
      <slot name="footer" />
    </div>
  </div>
</template>

<script setup>
// BaseCard - Core card component following the design system
// Supports different variants, shadows, and interactive states

const props = defineProps({
  variant: {
    type: String,
    default: 'default',
    validator: (value) => ['default', 'elevated', 'bordered', 'flat'].includes(value)
  },
  interactive: {
    type: Boolean,
    default: false
  },
  title: {
    type: String,
    default: null
  },
  padding: {
    type: String,
    default: 'md',
    validator: (value) => ['none', 'sm', 'md', 'lg'].includes(value)
  }
})

const cardClasses = computed(() => {
  const baseClasses = ['bg-white', 'rounded-lg', 'overflow-hidden']
  
  // Interactive states
  if (props.interactive) {
    baseClasses.push('cursor-pointer', 'transition-shadow', 'hover:shadow-medium')
  }
  
  // Variant styles
  const variantClasses = {
    default: ['shadow-soft'],
    elevated: ['shadow-medium'],
    bordered: ['border', 'border-secondary-200'],
    flat: ['shadow-none']
  }
  
  return [...baseClasses, ...variantClasses[props.variant]]
})

const contentClasses = computed(() => {
  const paddingClasses = {
    none: [],
    sm: ['p-4'],
    md: ['p-6'],
    lg: ['p-8']
  }
  
  return paddingClasses[props.padding]
})
</script>