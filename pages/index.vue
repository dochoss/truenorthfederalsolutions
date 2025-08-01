<template>
  <div>
    <!-- Hero Section -->
    <Hero />

    <!-- Services Overview -->
    <BaseSection title="Expert Federal Contracting Services"
      subtitle="From initial setup to winning proposals, we provide comprehensive support for your federal contracting journey."
      spacing="lg">
      <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-8 mb-8">
        <!-- Contracting Readiness & Set-Up -->
        <NuxtLink to="/services/contract-setup">
          <BaseCard fullHeight interactive padding="md" class="hover:shadow-medium transition-shadow">
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
          <BaseCard fullHeight interactive padding="md" class="hover:shadow-medium transition-shadow">
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
          <BaseCard fullHeight interactive padding="md" class="hover:shadow-medium transition-shadow">
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
          <BaseCard fullHeight interactive padding="md" class="hover:shadow-medium transition-shadow">
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
          <BaseCard fullHeight interactive padding="md" class="hover:shadow-medium transition-shadow">
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
          <h3 class="text-2xl font-bold text-secondary-900 mb-2">Decades of Real-World Experience</h3>
          <p class="text-secondary-600">
            Over 15 years of hands-on federal contracting expertise
          </p>
        </div>

        <!-- Expertise -->
        <div class="text-center">
          <IconWrapper icon="heroicons:academic-cap" variant="primary" size="lg" class="mx-auto mb-4" />
          <h3 class="text-2xl font-bold text-secondary-900 mb-2">Certified Acquisition Professional</h3>
          <p class="text-secondary-600">
            FAC-C Professional &amp; DAWIA Level III certified with deep knowledge of
            FAR, cost analysis, and full acquisition lifecycle strategy.
          </p>
        </div>

        <!-- Results -->
        <div class="text-center">
          <IconWrapper icon="heroicons:trophy" variant="primary" size="lg" class="mx-auto mb-4" />
          <h3 class="text-2xl font-bold text-secondary-900 mb-2">Results That Matter</h3>
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
