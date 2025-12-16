<template>
  <div>
    <!-- Resources Header -->
    <UPageHero class="relative isolate overflow-hidden bg-primary-700"
      title="Federal Contracting Resources"
      description="Access comprehensive guides, templates, and educational content to help you navigate the federal contracting landscape with confidence."
      :ui="{
        title: 'text-4xl sm:text-5xl md:text-6xl font-bold text-white',
        description: 'text-sm sm:text-lg text-white max-w-3xl mx-auto'
      }">
      <NuxtImg src="/conference-table-2.png" alt="Team collaborating around a conference table"
        class="absolute inset-0 -z-10 size-full object-cover brightness-[0.2]" />
      <div class="absolute inset-0 bg-primary-700/40 -z-10"></div>
    </UPageHero>

    <!-- Resource Categories -->
    <UPageSection>
      <div class="grid grid-cols-1 md:grid-cols-3 gap-8">
        <!-- Blog & Articles -->
        <UCard variant="subtle" class="h-full hover:shadow-md transition-shadow bg-secondary-50">
          <div class="text-center p-4">
            <UIcon name="i-heroicons-newspaper" class="w-12 h-12 text-primary-600 mx-auto mb-6" />
            <h3 class="text-xl font-bold text-secondary-900 mb-4">Blog & Articles</h3>
            <p class="text-secondary-600 mb-6">
              Stay updated with the latest insights, best practices, and industry news in federal contracting.
            </p>
            <UButton block trailing-icon="i-heroicons-arrow-right" to="https://www.linkedin.com/company/true-north-federal-solutions-llc/posts/" target="_blank" class="bg-primary-700 text-white hover:bg-primary-800">
              Read Articles
            </UButton>
          </div>
        </UCard>

        <!-- Guides & Templates -->
        <UCard variant="subtle" class="h-full hover:shadow-md transition-shadow bg-secondary-50">
          <div class="text-center p-4">
            <UIcon name="i-heroicons-document-arrow-down" class="w-12 h-12 text-primary-600 mx-auto mb-6" />
            <h3 class="text-xl font-bold text-secondary-900 mb-4">Guides & Templates</h3>
            <p class="text-secondary-600 mb-6">
              Download practical guides, checklists, and templates to streamline your federal contracting process.
            </p>
            <UButton block trailing-icon="i-heroicons-arrow-right" to="/guides" class="bg-primary-700 text-white hover:bg-primary-800">
              Browse Guides
            </UButton>
          </div>
        </UCard>

        <!-- Certification Help -->
        <UCard variant="subtle" class="h-full hover:shadow-md transition-shadow bg-secondary-50">
          <div class="text-center p-4">
            <UIcon name="i-heroicons-academic-cap" class="w-12 h-12 text-primary-600 mx-auto mb-6" />
            <h3 class="text-xl font-bold text-secondary-900 mb-4">Certification Help</h3>
            <p class="text-secondary-600 mb-6">
              Navigate the certification process for WOSB, VOSB, 8(a), and other small business programs.
            </p>
            <UButton block trailing-icon="i-heroicons-arrow-right" to="/resources/certifications" class="bg-primary-700 text-white hover:bg-primary-800">
              Get Certified
            </UButton>
          </div>
        </UCard>
      </div>
    </UPageSection>

    <!-- Featured Resources -->
    <UPageSection class="bg-secondary-50"
      title="Featured Resources"
      description="Popular downloads and essential guides for federal contracting success"
      :ui="{
        title: 'text-3xl sm:text-4xl lg:text-5xl text-pretty tracking-tight font-bold text-secondary-900',
        description: 'text-base sm:text-lg text-secondary-600'
      }">
      <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
        <UCard v-for="resource in featuredResources" :key="resource.title" 
          variant="subtle" 
          class="h-full hover:shadow-md transition-shadow bg-white flex flex-col"
          :ui="{ body: 'flex-1', footer: 'mt-auto' }">
          <template #header>
            <UIcon :name="resource.icon" class="w-8 h-8 text-primary-600" />
            <h3 class="text-lg font-semibold text-secondary-900 mt-3">
              {{ resource.title }}
            </h3>
          </template>
          <p class="text-secondary-600 text-sm">
            {{ resource.description }}
          </p>
          <template #footer>
            <div class="flex items-center justify-between">
              <span class="text-xs text-secondary-500">{{ resource.category }}</span>
              <UButton variant="ghost" size="sm" class="text-primary-600">
                Coming Soon
              </UButton>
            </div>
          </template>
        </UCard>
      </div>
    </UPageSection>

    <!-- CTA Section -->
    <CTA
      title="Ready to Access More Resources?"
      description="Schedule a consultation to discuss your federal contracting needs and get personalized guidance."
      :links="ctaLinks"
    />

    <!-- Tools Preview (Phase 2) -->
    <UPageSection class="bg-white">
      <UCard variant="subtle" class="bg-secondary-50 max-w-4xl mx-auto">
        <div class="text-center p-6">
          <UIcon name="i-heroicons-cog-6-tooth" class="w-16 h-16 text-primary-600 mx-auto mb-6" />
          <h2 class="text-2xl font-bold text-secondary-900 mb-4">
            AI-Powered Tools Coming Soon
          </h2>
          <p class="text-lg text-secondary-600 mb-6">
            We're developing intelligent assessment tools to help you make better decisions about federal contracting
            opportunities.
          </p>
          <div class="grid grid-cols-1 md:grid-cols-2 gap-6 text-left mb-8">
            <div class="flex items-start space-x-3">
              <UIcon name="i-heroicons-check-circle" class="w-5 h-5 text-primary-600 mt-1" />
              <div>
                <h3 class="font-semibold text-secondary-900">Business Readiness Assessment</h3>
                <p class="text-sm text-secondary-600">Evaluate your readiness for federal contracting</p>
              </div>
            </div>
            <div class="flex items-start space-x-3">
              <UIcon name="i-heroicons-check-circle" class="w-5 h-5 text-primary-600 mt-1" />
              <div>
                <h3 class="font-semibold text-secondary-900">Bid/No-Bid Decision Tool</h3>
                <p class="text-sm text-secondary-600">Get recommendations on which opportunities to pursue</p>
              </div>
            </div>
          </div>
          <UButton icon="i-heroicons-bell" to="/contact" class="bg-primary-700 text-white hover:bg-primary-800">
            Get Notified When Available
          </UButton>
        </div>
      </UCard>
    </UPageSection>
  </div>
</template>

<script setup>
const featuredResources = [
  {
    icon: 'i-heroicons-rocket-launch',
    title: 'Getting Started in Federal Contracting',
    description: 'A comprehensive guide to starting your federal contracting journey, from registration to first contract.',
    category: 'Beginner Guide'
  },
  {
    icon: 'i-heroicons-clipboard-document-check',
    title: 'SAM.gov Registration Checklist',
    description: 'Step-by-step checklist to ensure your SAM.gov registration is complete and accurate for federal contracting.',
    category: 'Essential Template'
  },
  {
    icon: 'i-heroicons-shield-check',
    title: 'WOSB Certification Guide',
    description: 'Complete guide to Woman-Owned Small Business certification, including requirements and application process.',
    category: 'Certification Guide'
  },
  {
    icon: 'i-heroicons-chart-bar',
    title: 'Proposal Writing Best Practices',
    description: 'Learn the key elements of winning federal proposals from a contracting officer\'s perspective.',
    category: 'Advanced Guide'
  },
  {
    icon: 'i-heroicons-exclamation-triangle',
    title: 'Common FAR Compliance Mistakes',
    description: 'Avoid costly mistakes by understanding the most common FAR compliance issues and how to prevent them.',
    category: 'Compliance Guide'
  },
  {
    icon: 'i-heroicons-calculator',
    title: 'Bid/No-Bid Decision Framework',
    description: 'Strategic framework to help you make informed decisions about which opportunities to pursue.',
    category: 'Strategy Tool'
  }
]

const ctaLinks = [
  {
    label: 'Schedule Consultation',
    to: '/contact',
    icon: 'i-heroicons-calendar-days',
    size: 'lg',
    color: 'neutral',
    variant: 'outline',
    class: 'flex items-center justify-center px-8 py-3 w-80 bg-secondary-100 hover:bg-secondary-300 hover:text-secondary-900 text-lg'
  },
  {
    label: 'Browse Guides',
    to: '/guides',
    icon: 'i-heroicons-book-open',
    size: 'lg',
    color: 'neutral',
    variant: 'outline',
    class: 'flex items-center justify-center px-8 py-3 w-80 bg-secondary-100 hover:bg-secondary-300 hover:text-secondary-900 text-lg'
  }
]

// Set page meta for SEO
definePageMeta({
  title: 'Resources - True North Federal Solutions',
  description: 'Federal contracting resources including guides, templates, blog articles, and certification help for small businesses.'
})

// Set head for SEO
useHead({
  title: 'Federal Contracting Resources - True North Federal Solutions',
  meta: [
    {
      name: 'description',
      content: 'Comprehensive federal contracting resources for small businesses. Access guides, templates, articles, and certification help to succeed in government contracting.'
    },
    {
      name: 'keywords',
      content: 'federal contracting resources, government contract guides, SAM.gov registration, WOSB certification, proposal writing, small business'
    }
  ]
})
</script>
