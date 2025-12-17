<template>
  <UPageCTA variant="naked" :title="title" :description="description" :links="links" :ui="ui"
    class="bg-primary-700 rounded-none" />
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
        class: 'flex items-center justify-center px-8 py-3 w-80 bg-secondary-100 hover:bg-secondary-300 hover:text-secondary-900 text-lg'
      },
      {
        label: 'Download Free Guides',
        to: '/resources',
        icon: 'i-heroicons-document-text',
        size: 'lg',
        class: 'flex items-center justify-center px-8 py-3 w-80 bg-secondary-100 hover:bg-secondary-300 hover:text-secondary-900 text-lg'
      }
    ]) as ButtonProps[]
  }
)

const ui = {
  title: 'text-3xl sm:text-4xl lg:text-5xl text-pretty tracking-tight font-bold text-white',
  description: 'text-base sm:text-lg text-primary-50'
}

const { title, description, links } = toRefs(props)
</script>