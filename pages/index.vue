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
      <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-8">
        <!-- Contract Setup -->
        <BaseCard interactive padding="md" class="hover:shadow-medium transition-shadow">
          <div class="text-center">
            <IconWrapper 
              icon="heroicons:document-text" 
              variant="primary" 
              size="lg" 
              class="mx-auto mb-6"
            />
            <h3 class="text-xl font-bold text-secondary-900 mb-4">Contract Setup</h3>
            <p class="text-secondary-600 mb-6">
              Get your business registered and ready for federal contracting with proper certifications and compliance.
            </p>
            <BaseButton variant="tertiary" size="sm" icon-right="heroicons:arrow-right">
              <NuxtLink to="/services/contract-setup">
                Learn More
              </NuxtLink>
            </BaseButton>
          </div>
        </BaseCard>

        <!-- Proposal Development -->
        <BaseCard interactive padding="md" class="hover:shadow-medium transition-shadow">
          <div class="text-center">
            <IconWrapper 
              icon="heroicons:pencil-square" 
              variant="primary" 
              size="lg" 
              class="mx-auto mb-6"
            />
            <h3 class="text-xl font-bold text-secondary-900 mb-4">Proposal Development</h3>
            <p class="text-secondary-600 mb-6">
              Craft winning proposals with strategic guidance from an experienced contracting officer perspective.
            </p>
            <BaseButton variant="tertiary" size="sm" icon-right="heroicons:arrow-right">
              <NuxtLink to="/services/proposal-development">
                Learn More
              </NuxtLink>
            </BaseButton>
          </div>
        </BaseCard>

        <!-- FAR Compliance -->
        <BaseCard interactive padding="md" class="hover:shadow-medium transition-shadow">
          <div class="text-center">
            <IconWrapper 
              icon="heroicons:shield-check" 
              variant="primary" 
              size="lg" 
              class="mx-auto mb-6"
            />
            <h3 class="text-xl font-bold text-secondary-900 mb-4">FAR Compliance</h3>
            <p class="text-secondary-600 mb-6">
              Ensure your business meets all Federal Acquisition Regulation requirements with expert guidance.
            </p>
            <BaseButton variant="tertiary" size="sm" icon-right="heroicons:arrow-right">
              <NuxtLink to="/services/far-compliance">
                Learn More
              </NuxtLink>
            </BaseButton>
          </div>
        </BaseCard>

        <!-- Strategic Consulting -->
        <BaseCard interactive padding="md" class="hover:shadow-medium transition-shadow">
          <div class="text-center">
            <IconWrapper 
              icon="heroicons:chart-bar" 
              variant="primary" 
              size="lg" 
              class="mx-auto mb-6"
            />
            <h3 class="text-xl font-bold text-secondary-900 mb-4">Strategic Consulting</h3>
            <p class="text-secondary-600 mb-6">
              Make informed bid/no-bid decisions with strategic analysis and win probability assessment.
            </p>
            <BaseButton variant="tertiary" size="sm" icon-right="heroicons:arrow-right">
              <NuxtLink to="/services/bid-no-bid-strategy">
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
