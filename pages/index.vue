<template>
  <div>
    <!-- Hero Section -->
    <div class="relative bg-white overflow-hidden">
      <!-- Background Image -->
      <div class="absolute inset-0">
        <NuxtImg src="/conference-table-hero.svg" alt="Professionals collaborating around a conference table"
          class="w-full h-full object-cover" loading="eager" />
        <!-- Overlay for contrast -->
        <div class="absolute inset-0 bg-gradient-to-r from-primary-900/90 via-primary-800/80 to-primary-700/70"></div>
      </div>

      <!-- Content -->
      <div class="relative max-w-7xl mx-auto">
        <div class="relative z-10 pb-8 sm:pb-16 md:pb-20 lg:max-w-2xl lg:w-full lg:pb-28 xl:pb-32">
          <!-- Blue section with content -->
          <div class="bg-primary-600 lg:bg-gradient-to-r lg:from-primary-600 lg:to-transparent lg:via-primary-600/95">
            <div class="pt-10 mx-auto max-w-7xl px-4 sm:pt-12 sm:px-6 md:pt-16 lg:pt-20 lg:px-8 xl:pt-28">
              <div class="text-center lg:text-left">
                <!-- Logo -->
                <NuxtImg src="/logo.svg" alt="True North Federal Solutions Logo" width="200" height="45"
                  class="mx-auto lg:mx-0 mb-6 bg-white rounded-full p-4" />

                <!-- Title -->
                <h1 class="text-4xl tracking-tight font-bold text-white sm:text-5xl md:text-6xl">
                  <span class="block">Federal Contracting</span>
                  <span class="block text-white font-extrabold">Success Starts Here</span>
                </h1>

                <!-- Updated tagline -->
                <p
                  class="mt-3 text-base text-primary-100 sm:mt-5 sm:text-lg sm:max-w-xl sm:mx-auto md:mt-5 md:text-xl lg:mx-0">
                  We Know the Rules — So You Can Win the Work.
                </p>

                <!-- CTA Buttons -->
                <div class="mt-5 sm:mt-8 sm:flex sm:justify-center lg:justify-start">
                  <div class="rounded-md shadow">
                    <BaseButton variant="secondary" size="lg" icon-left="heroicons:calendar-days"
                      class="w-full flex items-center justify-center px-8 py-3">
                      <NuxtLink to="/contact" class="flex items-center">
                        Schedule Consultation
                      </NuxtLink>
                    </BaseButton>
                  </div>
                  <div class="mt-3 sm:mt-0 sm:ml-3">
                    <BaseButton variant="secondary" size="lg" icon-left="heroicons:book-open"
                      class="w-full flex items-center justify-center px-8 py-3">
                      <NuxtLink to="/resources" class="flex items-center">
                        Explore Resources
                      </NuxtLink>
                    </BaseButton>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>

    <!-- Services Overview -->
    <BaseSection title="Expert Federal Contracting Services"
      subtitle="From initial setup to winning proposals, we provide comprehensive support for your federal contracting journey."
      spacing="lg">
      <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-8 mb-8">
        <!-- Contracting Readiness & Set-Up -->
        <NuxtLink to="/services/contract-setup">
          <BaseCard interactive padding="md" class="hover:shadow-medium transition-shadow">
            <div class="text-center">
              <IconWrapper icon="heroicons:cog-6-tooth" variant="primary" size="lg" class="mx-auto mb-6" />
              <h3 class="text-xl font-bold text-secondary-900 mb-4">Contracting Readiness & Set-Up</h3>
              <p class="text-secondary-600 mb-6">
                Get contract-ready with strategic setup and compliance tools. SAM.gov & State Registration Assistance,
                NAICS & PSC Code Optimization, and Capability Statement Development.
              </p>
              <BaseButton variant="tertiary" size="sm" icon-right="heroicons:arrow-right">
                Learn More
              </BaseButton>
            </div>
          </BaseCard>
        </NuxtLink>

        <!-- Opportunity Identification and Market Intelligence -->
        <NuxtLink to="/services/market-intelligence">
          <BaseCard interactive padding="md" class="hover:shadow-medium transition-shadow">
            <div class="text-center">
              <IconWrapper icon="heroicons:magnifying-glass" variant="primary" size="lg" class="mx-auto mb-6" />
              <h3 class="text-xl font-bold text-secondary-900 mb-4">Opportunity Identification and Market Intelligence
              </h3>
              <p class="text-secondary-600 mb-6">
                Find and target the right opportunities before your competition. Bid Matchmaking Services, Opportunity
                Tracking, and Strategic Targeting Plans.
              </p>
              <BaseButton variant="tertiary" size="sm" icon-right="heroicons:arrow-right">
                Learn More
              </BaseButton>
            </div>
          </BaseCard>
        </NuxtLink>

        <!-- Proposal Development & Management -->
        <NuxtLink to="/services/proposal-development">
          <BaseCard interactive padding="md" class="hover:shadow-medium transition-shadow">
            <div class="text-center">
              <IconWrapper icon="heroicons:pencil-square" variant="primary" size="lg" class="mx-auto mb-6" />
              <h3 class="text-xl font-bold text-secondary-900 mb-4">Proposal Development & Management</h3>
              <p class="text-secondary-600 mb-6">
                From RFP to submission — we manage the full proposal lifecycle. Proposal Writing & Management,
                Bid/No-Bid
                Strategy, and Submission Support & Formatting.
              </p>
              <BaseButton variant="tertiary" size="sm" icon-right="heroicons:arrow-right">
                Learn More
              </BaseButton>
            </div>
          </BaseCard>
        </NuxtLink>
      </div>

      <!-- Second row with 2 features -->
      <div class="grid grid-cols-1 md:grid-cols-2 gap-8 max-w-4xl mx-auto">
        <!-- Compliance & Regulatory Support -->
        <NuxtLink to="/services/far-compliance">
          <BaseCard interactive padding="md" class="hover:shadow-medium transition-shadow">
            <div class="text-center">
              <IconWrapper icon="heroicons:shield-check" variant="primary" size="lg" class="mx-auto mb-6" />
              <h3 class="text-xl font-bold text-secondary-900 mb-4">Compliance & Regulatory Support</h3>
              <p class="text-secondary-600 mb-6">
                Navigate the FAR and state-specific requirements with confidence. FAR Compliance Consulting, Contract
                Risk
                Mitigation, and Bonding Guidance.
              </p>
              <BaseButton variant="tertiary" size="sm" icon-right="heroicons:arrow-right">
                Learn More
              </BaseButton>
            </div>
          </BaseCard>
        </NuxtLink>

        <!-- Training & Capacity Building -->
        <NuxtLink to="/services/training">
          <BaseCard interactive padding="md" class="hover:shadow-medium transition-shadow">
            <div class="text-center">
              <IconWrapper icon="heroicons:academic-cap" variant="primary" size="lg" class="mx-auto mb-6" />
              <h3 class="text-xl font-bold text-secondary-900 mb-4">Training & Capacity Building</h3>
              <p class="text-secondary-600 mb-6">
                Equip your team with the knowledge to compete and win. Customized Government Contracting Training,
                Proposal Writing Best Practices, and Procurement Systems Navigation.
              </p>
              <BaseButton variant="tertiary" size="sm" icon-right="heroicons:arrow-right">
                Learn More
              </BaseButton>
            </div>
          </BaseCard>
        </NuxtLink>
      </div>
    </BaseSection>

    <!-- Trust Indicators -->
    <BaseSection variant="secondary" spacing="lg">
      <template #header>
        <div class="text-center">
          <h2 class="text-3xl font-bold text-secondary-900 mb-4">
            Why Choose True North Federal Solutions?
          </h2>
          <p class="text-lg text-secondary-600 max-w-2xl mx-auto">
            Experience and expertise you can trust
          </p>
        </div>
      </template>

      <div class="grid grid-cols-1 md:grid-cols-3 gap-8">
        <!-- Experience -->
        <div class="text-center">
          <IconWrapper icon="heroicons:star" variant="primary" size="lg" class="mx-auto mb-4" />
          <h3 class="text-2xl font-bold text-secondary-900 mb-2">15+ Years</h3>
          <p class="text-secondary-600">
            Federal service experience from GS-06 to Contracting Officer
          </p>
        </div>

        <!-- Expertise -->
        <div class="text-center">
          <IconWrapper icon="heroicons:academic-cap" variant="primary" size="lg" class="mx-auto mb-4" />
          <h3 class="text-2xl font-bold text-secondary-900 mb-2">Certified Expert</h3>
          <p class="text-secondary-600">
            Licensed contracting officer with deep FAR knowledge and practical experience
          </p>
        </div>

        <!-- Results -->
        <div class="text-center">
          <IconWrapper icon="heroicons:trophy" variant="primary" size="lg" class="mx-auto mb-4" />
          <h3 class="text-2xl font-bold text-secondary-900 mb-2">Proven Results</h3>
          <p class="text-secondary-600">
            Helping small businesses successfully enter and compete in federal markets
          </p>
        </div>
      </div>
    </BaseSection>

    <!-- CTA Section -->
    <BaseSection variant="primary" spacing="lg" centered>
      <template #header>
        <h2 class="text-3xl text-left md:text-center font-bold text-white mb-4">
          Ready to Start Your Federal Contracting Journey?
        </h2>
        <p class="text-xl text-left md:text-center text-primary-100 mb-8">
          Schedule a consultation to discuss your business goals and learn how we can help you succeed.
        </p>
      </template>

      <div class="flex flex-col sm:flex-row justify-center space-y-4 sm:space-y-0 sm:space-x-4">
        <BaseButton variant="secondary" size="lg" icon-left="heroicons:phone">
          <NuxtLink to="/contact">
            Schedule Consultation
          </NuxtLink>
        </BaseButton>
        <BaseButton variant="secondary" size="lg" icon-left="heroicons:document-text">
          <NuxtLink to="/resources">
            Download Free Guide
          </NuxtLink>
        </BaseButton>
      </div>
    </BaseSection>
  </div>
</template>

<script setup>
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
