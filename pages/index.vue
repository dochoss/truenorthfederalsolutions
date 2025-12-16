<template>
  <div>
    <!-- Hero Section -->
    <Hero />

    <!-- Services Overview -->
    <UPageSection title="Expert Federal Contracting Services"
      description="From initial setup to winning proposals, we provide comprehensive support for your federal contracting journey."
      :ui="{
        title: 'text-3xl sm:text-4xl lg:text-5xl text-pretty tracking-tight font-bold text-secondary-900',
        description: 'text-base sm:text-lg text-secondary-600'
      }">
      <template #body>
        <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-8 mb-8">
          <!-- Contracting Readiness & Set-Up -->
          <NuxtLink to="/services/contract-setup">
            <UCard variant="subtle" :class="{ 'h-full': true }" interactive padding="md"
              class="bg-secondary-50 hover:shadow-medium transition-shadow">
              <div class="text-center">
                <UIcon name="i-heroicons-cog-6-tooth" class="w-12 h-12 text-primary-600 mx-auto mb-6" />
                <h3 class="text-xl font-bold text-secondary-900 mb-4">Contracting Readiness & Set-Up</h3>
                <p class="text-secondary-600 mb-6">
                  Get contract-ready with strategic setup and compliance tools. SAM.gov & State Registration Assistance,
                  NAICS & PSC Code Optimization, and Capability Statement Development.
                </p>
                <UButton color="primary" variant="ghost" size="sm" trailing-icon="i-heroicons-arrow-right"
                  class="text-primary-600">
                  Learn More
                </UButton>
              </div>
            </UCard>
          </NuxtLink>

          <!-- Opportunity Identification and Market Intelligence -->
          <NuxtLink to="/services/market-intelligence">
            <UCard variant="subtle" :class="{ 'h-full': true }" interactive padding="md"
              class="bg-secondary-50 hover:shadow-medium transition-shadow">
              <div class="text-center">
                <UIcon name="i-heroicons-magnifying-glass" class="w-12 h-12 text-primary-600 mx-auto mb-6" />
                <h3 class="text-xl font-bold text-secondary-900 mb-4">Opportunity Identification and Market Intelligence
                </h3>
                <p class="text-secondary-600 mb-6">
                  Find and target the right opportunities before your competition. Bid Matchmaking Services, Opportunity
                  Tracking, and Strategic Targeting Plans.
                </p>
                <UButton color="primary" variant="ghost" size="sm" trailing-icon="i-heroicons-arrow-right"
                  class="text-primary-600">
                  Learn More
                </UButton>
              </div>
            </UCard>
          </NuxtLink>

          <!-- Proposal Development & Management -->
          <NuxtLink to="/services/proposal-development">
            <UCard variant="subtle" :class="{ 'h-full': true }" interactive padding="md"
              class="bg-secondary-50 hover:shadow-medium transition-shadow">
              <div class="text-center">
                <UIcon name="i-heroicons-pencil-square" class="w-12 h-12 text-primary-600 mx-auto mb-6" />
                <h3 class="text-xl font-bold text-secondary-900 mb-4">Proposal Development & Management</h3>
                <p class="text-secondary-600 mb-6">
                  From RFP to submission — we manage the full proposal lifecycle. Proposal Writing & Management,
                  Bid/No-Bid
                  Strategy, and Submission Support & Formatting.
                </p>
                <UButton color="primary" variant="ghost" size="sm" trailing-icon="i-heroicons-arrow-right"
                  class="text-primary-600">
                  Learn More
                </UButton>
              </div>
            </UCard>
          </NuxtLink>
        </div>

        <!-- Second row with 2 features -->
        <div class="grid grid-cols-1 md:grid-cols-2 gap-8 max-w-4xl mx-auto">
          <!-- Compliance & Regulatory Support -->
          <NuxtLink to="/services/far-compliance">
            <UCard variant="subtle" :class="{ 'h-full': true }" interactive padding="md"
              class="bg-secondary-50 hover:shadow-medium transition-shadow">
              <div class="text-center">
                <UIcon name="i-heroicons-shield-check" class="w-12 h-12 text-primary-600 mx-auto mb-6" />
                <h3 class="text-xl font-bold text-secondary-900 mb-4">Compliance & Regulatory Support</h3>
                <p class="text-secondary-600 mb-6">
                  Navigate the FAR and state-specific requirements with confidence. FAR Compliance Consulting, Contract
                  Risk
                  Mitigation, and Bonding Guidance.
                </p>
                <UButton color="primary" variant="ghost" size="sm" trailing-icon="i-heroicons-arrow-right"
                  class="text-primary-600">
                  Learn More
                </UButton>
              </div>
            </UCard>
          </NuxtLink>

          <!-- Training & Capacity Building -->
          <NuxtLink to="/services/training">
            <UCard variant="subtle" :class="{ 'h-full': true }" interactive padding="md"
              class="bg-secondary-50 hover:shadow-medium transition-shadow">
              <div class="text-center">
                <UIcon name="i-heroicons-academic-cap" class="w-12 h-12 text-primary-600 mx-auto mb-6" />
                <h3 class="text-xl font-bold text-secondary-900 mb-4">Training & Capacity Building</h3>
                <p class="text-secondary-600 mb-6">
                  Equip your team with the knowledge to compete and win. Customized Government Contracting Training,
                  Proposal Writing Best Practices, and Procurement Systems Navigation.
                </p>
                <UButton color="primary" variant="ghost" size="sm" trailing-icon="i-heroicons-arrow-right"
                  class="text-primary-600">
                  Learn More
                </UButton>
              </div>
            </UCard>
          </NuxtLink>
        </div>
      </template>
    </UPageSection>

    <section class="h-32 bg-primary-900"></section>

    <!-- Trust Indicators -->
    <div class="bg-secondary-50">
      <UPageSection title="Why Choose True North Federal Solutions?"
        description="Experience and expertise you can trust" :ui="{
          title: 'text-3xl sm:text-4xl lg:text-5xl text-pretty tracking-tight font-bold text-secondary-900',
          description: 'text-base sm:text-lg text-secondary-600'
        }">
        <template #body>
          <div class="grid grid-cols-1 md:grid-cols-3 gap-8">
            <div v-for="feature in whyChooseFeatures" :key="feature.title" class="text-center">
              <UIcon :name="feature.icon" class="w-12 h-12 text-primary-600 mx-auto mb-4" />
              <h3 class="text-xl font-bold text-secondary-900 mb-2">{{ feature.title }}</h3>
              <p class="text-secondary-600">{{ feature.description }}</p>
            </div>
          </div>
        </template>
      </UPageSection>
    </div>

    <!-- CTA Section -->
    <div class="bg-primary-600">
      <UPageSection title="Ready to Start Your Federal Contracting Journey?"
        description="Schedule a consultation to discuss your business goals and learn how we can help you succeed."
        :links="ctaLinks" :ui="{
          title: 'text-3xl sm:text-4xl lg:text-5xl text-pretty tracking-tight font-bold text-white',
          description: 'text-base sm:text-lg text-primary-100',
          links: 'flex flex-wrap gap-x-6 gap-y-3 justify-center'
        }" />
    </div>
  </div>
</template>

<script setup>
const whyChooseFeatures = [
  {
    title: 'Decades of Real-World Experience',
    description: 'Over 15 years of hands-on federal contracting expertise',
    icon: 'i-heroicons-star'
  },
  {
    title: 'Certified Acquisition Professional',
    description: 'FAC-C Professional & DAWIA Level III certified with deep knowledge of FAR, cost analysis, and full acquisition lifecycle strategy.',
    icon: 'i-heroicons-academic-cap'
  },
  {
    title: 'Results That Matter',
    description: 'Helping small businesses successfully enter and compete in federal markets',
    icon: 'i-heroicons-trophy'
  }
]

const ctaLinks = [
  {
    label: 'Schedule Consultation',
    to: '/contact',
    icon: 'i-heroicons-phone',
    size: 'lg',
    color: 'neutral',
    variant: 'outline',
    class: 'px-8 py-3 hover:bg-secondary-100 hover:text-secondary-900 text-lg'
  },
  {
    label: 'Download Free Guide',
    to: '/resources',
    icon: 'i-heroicons-document-text',
    size: 'lg',
    color: 'neutral',
    variant: 'outline',
    class: 'px-8 py-3 hover:bg-secondary-100 hover:text-secondary-900 text-lg'
  }
]

// Set page meta for SEO
definePageMeta({
  title: 'Home - True North Federal Solutions',
  description: 'Expert federal contracting consulting services. Navigate government procurement with confidence. 15+ years of contracting officer experience.'
})

// Set head for SEO
useHead({
  title: 'Federal Contracting Experts - True North Federal Solutions',
  meta: [
    {
      name: 'description',
      content: 'Expert federal contracting consulting from experienced contracting officers. Contract setup, proposal development, FAR compliance, and strategic guidance.'
    },
    {
      name: 'keywords',
      content: 'federal contracting, government contracts, small business, consulting, proposal development, FAR compliance, contracting officer'
    }
  ]
})
</script>
