<template>
  <div>    
    <!-- Hero Section -->
    <BaseSection variant="primary" spacing="xl" centered>
      <template #header>
        <NuxtImg src="/logo.svg" 
                 alt="True North Federal Solutions Logo" 
                 width="225" 
                 height="50" 
                 class="mx-auto mb-6 bg-white rounded-full p-5" />
        <h1 class="text-4xl text-center sm:text-5xl md:text-6xl font-bold text-white mb-6">
          Federal Contracting
          <span class="block text-gray-900 font-extrabold">Success Starts Here</span>
        </h1>
        <p class="text-xl text-center text-primary-100 mb-8 max-w-3xl mx-auto">
          Expert guidance from a seasoned contracting officer with 15 years of federal service. 
          Navigate the complex world of government procurement with confidence and expertise.
        </p>
      </template>
      
      <div class="flex flex-col sm:flex-row gap-4 justify-center">
        <BaseButton 
          variant="secondary" 
          size="lg"
          icon-left="heroicons:calendar-days"
        >
          <NuxtLink to="/contact" class="flex items-center">
            Schedule Consultation
          </NuxtLink>
        </BaseButton>
        <BaseButton 
          variant="secondary" 
          size="lg"
          icon-left="heroicons:book-open"
        >
          <NuxtLink to="/resources" class="flex items-center">
            Explore Resources
          </NuxtLink>
        </BaseButton>
      </div>
    </BaseSection>

    <!-- Services Overview -->
    <BaseSection 
      title="Expert Federal Contracting Services" 
      subtitle="From initial setup to winning proposals, we provide comprehensive support for your federal contracting journey."
      spacing="lg"
    >
      <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-8 mb-8">
        <!-- Contracting Readiness & Set-Up -->
        <BaseCard interactive padding="md" class="hover:shadow-medium transition-shadow">
          <div class="text-center">
            <IconWrapper 
              icon="heroicons:cog-6-tooth" 
              variant="primary" 
              size="lg" 
              class="mx-auto mb-6"
            />
            <h3 class="text-xl font-bold text-secondary-900 mb-4">Contracting Readiness & Set-Up</h3>
            <p class="text-secondary-600 mb-6">
              Get contract-ready with strategic setup and compliance tools. SAM.gov & State Registration Assistance, NAICS & PSC Code Optimization, and Capability Statement Development.
            </p>
            <BaseButton variant="tertiary" size="sm" icon-right="heroicons:arrow-right">
              <NuxtLink to="/services/contract-setup">
                Learn More
              </NuxtLink>
            </BaseButton>
          </div>
        </BaseCard>

        <!-- Opportunity Identification and Market Intelligence -->
        <BaseCard interactive padding="md" class="hover:shadow-medium transition-shadow">
          <div class="text-center">
            <IconWrapper 
              icon="heroicons:magnifying-glass" 
              variant="primary" 
              size="lg" 
              class="mx-auto mb-6"
            />
            <h3 class="text-xl font-bold text-secondary-900 mb-4">Opportunity Identification and Market Intelligence</h3>
            <p class="text-secondary-600 mb-6">
              Find and target the right opportunities before your competition. Bid Matchmaking Services, Opportunity Tracking, and Strategic Targeting Plans.
            </p>
            <BaseButton variant="tertiary" size="sm" icon-right="heroicons:arrow-right">
              <NuxtLink to="/services/market-intelligence">
                Learn More
              </NuxtLink>
            </BaseButton>
          </div>
        </BaseCard>

        <!-- Proposal Development & Management -->
        <BaseCard interactive padding="md" class="hover:shadow-medium transition-shadow">
          <div class="text-center">
            <IconWrapper 
              icon="heroicons:pencil-square" 
              variant="primary" 
              size="lg" 
              class="mx-auto mb-6"
            />
            <h3 class="text-xl font-bold text-secondary-900 mb-4">Proposal Development & Management</h3>
            <p class="text-secondary-600 mb-6">
              From RFP to submission — we manage the full proposal lifecycle. Proposal Writing & Management, Bid/No-Bid Strategy, and Submission Support & Formatting.
            </p>
            <BaseButton variant="tertiary" size="sm" icon-right="heroicons:arrow-right">
              <NuxtLink to="/services/proposal-development">
                Learn More
              </NuxtLink>
            </BaseButton>
          </div>
        </BaseCard>
      </div>
      
      <!-- Second row with 2 features -->
      <div class="grid grid-cols-1 md:grid-cols-2 gap-8 max-w-4xl mx-auto">
        <!-- Compliance & Regulatory Support -->
        <BaseCard interactive padding="md" class="hover:shadow-medium transition-shadow">
          <div class="text-center">
            <IconWrapper 
              icon="heroicons:shield-check" 
              variant="primary" 
              size="lg" 
              class="mx-auto mb-6"
            />
            <h3 class="text-xl font-bold text-secondary-900 mb-4">Compliance & Regulatory Support</h3>
            <p class="text-secondary-600 mb-6">
              Navigate the FAR and state-specific requirements with confidence. FAR Compliance Consulting, Contract Risk Mitigation, and Bonding Guidance.
            </p>
            <BaseButton variant="tertiary" size="sm" icon-right="heroicons:arrow-right">
              <NuxtLink to="/services/far-compliance">
                Learn More
              </NuxtLink>
            </BaseButton>
          </div>
        </BaseCard>

        <!-- Training & Capacity Building -->
        <BaseCard interactive padding="md" class="hover:shadow-medium transition-shadow">
          <div class="text-center">
            <IconWrapper 
              icon="heroicons:academic-cap" 
              variant="primary" 
              size="lg" 
              class="mx-auto mb-6"
            />
            <h3 class="text-xl font-bold text-secondary-900 mb-4">Training & Capacity Building</h3>
            <p class="text-secondary-600 mb-6">
              Equip your team with the knowledge to compete and win. Customized Government Contracting Training, Proposal Writing Best Practices, and Procurement Systems Navigation.
            </p>
            <BaseButton variant="tertiary" size="sm" icon-right="heroicons:arrow-right">
              <NuxtLink to="/services/training">
                Learn More
              </NuxtLink>
            </BaseButton>
          </div>
        </BaseCard>
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
          <IconWrapper 
            icon="heroicons:star" 
            variant="primary" 
            size="lg" 
            class="mx-auto mb-4"
          />
          <h3 class="text-2xl font-bold text-secondary-900 mb-2">15+ Years</h3>
          <p class="text-secondary-600">
            Federal service experience from GS-06 to Contracting Officer
          </p>
        </div>

        <!-- Expertise -->
        <div class="text-center">
          <IconWrapper 
            icon="heroicons:academic-cap" 
            variant="primary" 
            size="lg" 
            class="mx-auto mb-4"
          />
          <h3 class="text-2xl font-bold text-secondary-900 mb-2">Certified Expert</h3>
          <p class="text-secondary-600">
            Licensed contracting officer with deep FAR knowledge and practical experience
          </p>
        </div>

        <!-- Results -->
        <div class="text-center">
          <IconWrapper 
            icon="heroicons:trophy" 
            variant="primary" 
            size="lg" 
            class="mx-auto mb-4"
          />
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
        <BaseButton 
          variant="secondary" 
          size="lg"
          icon-left="heroicons:phone"
        >
          <NuxtLink to="/contact">
            Schedule Consultation
          </NuxtLink>
        </BaseButton>
        <BaseButton 
          variant="secondary" 
          size="lg"
          icon-left="heroicons:document-text"
        >
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
