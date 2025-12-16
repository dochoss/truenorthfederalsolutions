<template>
  <UPageCTA
    variant="naked"
    :title="title"
    :description="description"
    :links="links"
    :ui="ui"
    class="bg-primary-700 rounded-none"
  />
</template>

<script setup lang="ts">
import { toRefs } from 'vue'
import type { ButtonProps } from '#ui/types'

const props = withDefaults(
  defineProps<{
    title?: string
    description?: string
    links?: ButtonProps[]
  }>(),
  {
    title: 'Ready to Start Your Federal Contracting Journey?',
    description: 'Schedule a consultation to discuss your business goals and learn how we can help you succeed.',
    links: () => ([
      {
        label: 'Schedule Consultation',
        to: '/contact',
        icon: 'i-heroicons-calendar-days',
        size: 'lg',
        color: 'primary',
        variant: 'solid'
      },
      {
        label: 'Download Free Guide',
        to: '/resources',
        icon: 'i-heroicons-document-text',
        size: 'lg',
        color: 'neutral',
        variant: 'outline'
      }
    ]) as ButtonProps[]
  }
)

const ui = {
  title: 'text-3xl sm:text-4xl lg:text-5xl text-pretty tracking-tight font-bold text-white',
  description: 'text-base sm:text-lg text-primary-100'
}

const { title, description, links } = toRefs(props)
</script>