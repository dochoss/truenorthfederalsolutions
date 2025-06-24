<template>
  <div class="space-y-1">
    <label 
      v-if="label" 
      :for="inputId" 
      :class="labelClasses"
    >
      {{ label }}
      <span v-if="required" class="text-danger-500 ml-1">*</span>
    </label>
    
    <div class="relative">
      <Icon 
        v-if="iconLeft" 
        :name="iconLeft" 
        class="absolute left-3 top-1/2 transform -translate-y-1/2 w-5 h-5 text-secondary-400"
      />
      
      <input
        :id="inputId"
        :type="type"
        :value="modelValue"
        :placeholder="placeholder"
        :disabled="disabled"
        :required="required"
        :class="inputClasses"
        @input="$emit('update:modelValue', $event.target.value)"
        @blur="$emit('blur', $event)"
        @focus="$emit('focus', $event)"
      >
      
      <Icon 
        v-if="iconRight" 
        :name="iconRight" 
        class="absolute right-3 top-1/2 transform -translate-y-1/2 w-5 h-5 text-secondary-400"
      />
    </div>
    
    <div v-if="error || hint" class="mt-1">
      <p v-if="error" class="text-sm text-danger-600">
        {{ error }}
      </p>
      <p v-else-if="hint" class="text-sm text-secondary-500">
        {{ hint }}
      </p>
    </div>
  </div>
</template>

<script setup>
// FormInput - Standard form input component following design system
// Supports validation states, icons, and accessibility

const props = defineProps({
  modelValue: {
    type: [String, Number],
    default: ''
  },
  type: {
    type: String,
    default: 'text'
  },
  label: {
    type: String,
    default: null
  },
  placeholder: {
    type: String,
    default: null
  },
  hint: {
    type: String,
    default: null
  },
  error: {
    type: String,
    default: null
  },
  disabled: {
    type: Boolean,
    default: false
  },
  required: {
    type: Boolean,
    default: false
  },
  iconLeft: {
    type: String,
    default: null
  },
  iconRight: {
    type: String,
    default: null
  },
  size: {
    type: String,
    default: 'md',
    validator: (value) => ['sm', 'md', 'lg'].includes(value)
  }
})

defineEmits(['update:modelValue', 'blur', 'focus'])

// Generate unique ID for accessibility
const inputId = computed(() => {
  return `input-${Math.random().toString(36).substr(2, 9)}`
})

const labelClasses = computed(() => {
  return [
    'block',
    'text-sm',
    'font-medium',
    'text-secondary-700'
  ]
})

const inputClasses = computed(() => {
  const baseClasses = [
    'block',
    'w-full',
    'border',
    'rounded-md',
    'shadow-sm',
    'transition-colors',
    'focus:outline-none',
    'focus:ring-2',
    'focus:ring-offset-0',
    'disabled:bg-secondary-50',
    'disabled:text-secondary-500',
    'disabled:cursor-not-allowed'
  ]
  
  // Size variants
  const sizeClasses = {
    sm: ['px-3', 'py-1.5', 'text-sm'],
    md: ['px-3', 'py-2', 'text-base'],
    lg: ['px-4', 'py-3', 'text-lg']
  }
  
  // Icon padding adjustments
  if (props.iconLeft) {
    const leftPaddingClasses = {
      sm: ['pl-9'],
      md: ['pl-10'],
      lg: ['pl-11']
    }
    baseClasses.push(...leftPaddingClasses[props.size])
  }
  
  if (props.iconRight) {
    const rightPaddingClasses = {
      sm: ['pr-9'],
      md: ['pr-10'],
      lg: ['pr-11']
    }
    baseClasses.push(...rightPaddingClasses[props.size])
  }
  
  // State-based styling
  if (props.error) {
    baseClasses.push(
      'border-danger-300',
      'text-danger-900',
      'placeholder-danger-300',
      'focus:ring-danger-500',
      'focus:border-danger-500'
    )
  } else {
    baseClasses.push(
      'border-secondary-300',
      'text-secondary-900',
      'placeholder-secondary-400',
      'focus:ring-primary-500',
      'focus:border-primary-500'
    )
  }
  
  return [
    ...baseClasses,
    ...sizeClasses[props.size]
  ]
})
</script>