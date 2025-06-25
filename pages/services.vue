<template>
  <div>
    <!-- Services Header -->
    <BaseSection variant="secondary" spacing="lg" centered>
      <template #header>
        <IconWrapper 
          icon="heroicons:briefcase" 
          variant="primary" 
          size="xl" 
          class="mx-auto mb-6"
        />
        <h1 class="text-4xl font-bold text-secondary-900 mb-4">
          Federal Contracting Services
        </h1>
        <p class="text-xl text-secondary-600 max-w-2xl mx-auto">
          Expert guidance to navigate the complex world of federal contracting. From initial setup to proposal development, we're here to help your business succeed.
        </p>
      </template>
    </BaseSection>

    <!-- Services Overview -->
    <BaseSection 
      title="Comprehensive Federal Contracting Support" 
      subtitle="With 15 years of federal service experience, from GS-06 to Contracting Officer, we provide the expertise you need to successfully navigate federal procurement."
      spacing="lg"
    >
      <!-- Service Cards -->
      <div class="grid grid-cols-1 md:grid-cols-2 gap-8 mb-12">
        <!-- Federal Contract Setup -->
        <BaseCard variant="elevated" padding="lg" interactive>
          <IconWrapper 
            icon="heroicons:document-text" 
            variant="primary" 
            size="lg" 
            class="mb-6"
          />
          <h3 class="text-xl font-bold text-secondary-900 mb-4">Federal Contract Setup</h3>
          <p class="text-secondary-600 mb-6">
            Get your business ready for federal contracting with proper registrations, certifications, and compliance foundation.
          </p>
          <ul class="text-sm text-secondary-600 space-y-2 mb-6">
            <li>• SAM.gov registration and maintenance</li>
            <li>• CAGE code acquisition</li>
            <li>• NAICS code selection and strategy</li>
            <li>• Small business certifications (WOSB, VOSB, 8a)</li>
            <li>• Compliance systems setup</li>
          </ul>
          <BaseButton variant="tertiary" icon-right="heroicons:arrow-right">
            <NuxtLink to="/services/contract-setup">
              Learn More
            </NuxtLink>
          </BaseButton>
        </BaseCard>

        <!-- Proposal Development -->
        <BaseCard variant="elevated" padding="lg" interactive>
          <IconWrapper 
            icon="heroicons:pencil-square" 
            variant="success" 
            size="lg" 
            class="mb-6"
          />
          <h3 class="text-xl font-bold text-secondary-900 mb-4">Proposal Development</h3>
          <p class="text-secondary-600 mb-6">
            Craft winning proposals with strategic guidance from an experienced contracting officer perspective.
          </p>
          <ul class="text-sm text-secondary-600 space-y-2 mb-6">
            <li>• Opportunity analysis and strategy</li>
            <li>• Proposal writing and review</li>
            <li>• Technical and price evaluation</li>
            <li>• Past performance documentation</li>
            <li>• Submission support and follow-up</li>
          </ul>
          <BaseButton variant="tertiary" icon-right="heroicons:arrow-right">
            <NuxtLink to="/services/proposal-development">
              Learn More
            </NuxtLink>
          </BaseButton>
        </BaseCard>

        <!-- FAR Compliance -->
        <BaseCard variant="elevated" padding="lg" interactive>
          <IconWrapper 
            icon="heroicons:shield-check" 
            variant="warning" 
            size="lg" 
            class="mb-6"
          />
          <h3 class="text-xl font-bold text-secondary-900 mb-4">FAR Compliance Consulting</h3>
          <p class="text-secondary-600 mb-6">
            Ensure your business meets all Federal Acquisition Regulation requirements with expert guidance and ongoing support.
          </p>
          <ul class="text-sm text-secondary-600 space-y-2 mb-6">
            <li>• FAR compliance audits and assessments</li>
            <li>• Training and education programs</li>
            <li>• Documentation and process setup</li>
            <li>• Ongoing compliance monitoring</li>
            <li>• Risk assessment and mitigation</li>
          </ul>
          <BaseButton variant="tertiary" icon-right="heroicons:arrow-right">
            <NuxtLink to="/services/far-compliance">
              Learn More
            </NuxtLink>
          </BaseButton>
        </BaseCard>

        <!-- Bid/No-Bid Strategy -->
        <BaseCard variant="elevated" padding="lg" interactive>
          <IconWrapper 
            icon="heroicons:chart-bar" 
            variant="accent" 
            size="lg" 
            class="mb-6"
          />
          <h3 class="text-xl font-bold text-secondary-900 mb-4">Bid/No-Bid Strategy</h3>
          <p class="text-secondary-600 mb-6">
            Make informed decisions about which opportunities to pursue with strategic analysis and win probability assessment.
          </p>
          <ul class="text-sm text-secondary-600 space-y-2 mb-6">
            <li>• Opportunity analysis and evaluation</li>
            <li>• Win probability assessment</li>
            <li>• Resource requirement analysis</li>
            <li>• ROI projections and modeling</li>
            <li>• Strategic recommendations</li>
          </ul>
          <BaseButton variant="tertiary" icon-right="heroicons:arrow-right">
            <NuxtLink to="/services/bid-no-bid-strategy">
              Learn More
            </NuxtLink>
          </BaseButton>
        </BaseCard>
      </div>
    </BaseSection>

    <!-- Process Overview -->
    <BaseSection variant="secondary" title="Our Process" subtitle="A structured approach to federal contracting success" spacing="lg">
      <div class="grid grid-cols-1 md:grid-cols-4 gap-8">
        <!-- Step 1 -->
        <div class="text-center">
          <div class="flex items-center justify-center w-16 h-16 bg-primary-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
            1
          </div>
          <h3 class="text-lg font-semibold text-secondary-900 mb-3">Assessment</h3>
          <p class="text-secondary-600 text-sm">
            Evaluate your business readiness and identify opportunities for federal contracting success.
          </p>
        </div>

        <!-- Step 2 -->
        <div class="text-center">
          <div class="flex items-center justify-center w-16 h-16 bg-primary-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
            2
          </div>
          <h3 class="text-lg font-semibold text-secondary-900 mb-3">Strategy</h3>
          <p class="text-secondary-600 text-sm">
            Develop a customized strategy based on your capabilities, market opportunities, and business goals.
          </p>
        </div>

        <!-- Step 3 -->
        <div class="text-center">
          <div class="flex items-center justify-center w-16 h-16 bg-primary-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
            3
          </div>
          <h3 class="text-lg font-semibold text-secondary-900 mb-3">Implementation</h3>
          <p class="text-secondary-600 text-sm">
            Execute the strategy with hands-on support for registrations, certifications, and compliance setup.
          </p>
        </div>

        <!-- Step 4 -->
        <div class="text-center">
          <div class="flex items-center justify-center w-16 h-16 bg-primary-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
            4
          </div>
          <h3 class="text-lg font-semibold text-secondary-900 mb-3">Success</h3>
          <p class="text-secondary-600 text-sm">
            Ongoing support to help you win contracts and grow your federal business successfully.
          </p>
        </div>
      </div>
    </BaseSection>

    <!-- CTA Section -->
    <BaseSection variant="primary" spacing="lg" centered>
      <template #header>
        <h2 class="text-3xl font-bold text-white mb-4">
          Ready to Start Your Federal Contracting Journey?
        </h2>
        <p class="text-xl text-primary-100 mb-8">
          Schedule a consultation to discuss your business goals and learn how we can help you succeed in federal contracting.
        </p>
      </template>
      
      <div class="flex flex-col sm:flex-row justify-center space-y-4 sm:space-y-0 sm:space-x-4">
        <BaseButton variant="secondary" size="lg" icon-left="heroicons:calendar-days">
          <NuxtLink to="/contact">
            Schedule Consultation
          </NuxtLink>
        </BaseButton>
        <BaseButton variant="tertiary" size="lg" icon-left="heroicons:book-open">
          <NuxtLink to="/resources">
            Explore Resources
          </NuxtLink>
        </BaseButton>
      </div>
    </BaseSection>

    <FooterSection />
  </div>
</template>

<script setup>
// Set page meta for SEO
definePageMeta({
  title: 'Services - True North Federal Solutions',
  description: 'Expert federal contracting services including contract setup, proposal development, FAR compliance, and bid/no-bid strategy consulting.'
})

// Set head for SEO
useHead({
  title: 'Federal Contracting Services - True North Federal Solutions',
  meta: [
    { 
      name: 'description', 
      content: 'Professional federal contracting services for small businesses. Expert guidance on contract setup, proposal development, FAR compliance, and strategic consulting.' 
    },
    { 
      name: 'keywords', 
      content: 'federal contracting services, small business consulting, government contracts, proposal development, FAR compliance, bid strategy' 
    }
  ]
})
</script>