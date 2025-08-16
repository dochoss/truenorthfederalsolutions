<template>
  <div>
    <!-- Services Header -->
    <BaseSection variant="secondary" spacing="lg" centered>
      <template #header>
        <IconWrapper icon="heroicons:briefcase" variant="primary" size="xl" class="mx-auto mb-6" />
        <h1 class="text-4xl text-center font-bold text-secondary-900 mb-4">
          Federal Contracting Services
        </h1>
        <p class="text-xl text-secondary-600 max-w-2xl mx-auto">
          Expert guidance to navigate the complex world of federal contracting. From initial setup to proposal
          development, we're here to help your business succeed.
        </p>
      </template>
    </BaseSection>

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
                Get contract-ready with strategic setup and compliance tools.
              </p>
              <div class="text-left text-sm text-secondary-600 space-y-2 mb-6">
                <p class="font-medium">• SAM.gov & State Registration Assistance:</p>
                <p class="pl-4">Full review and setup for SAM.gov, Texas.gov, and other essential platforms.</p>
                <p class="font-medium">• NAICS & PSC Code Optimization:</p>
                <p class="pl-4">Align your business classification codes to your current and future capabilities for maximum eligibility.</p>
                <p class="font-medium">• Capability Statement Development:</p>
                <p class="pl-4">Professionally crafted narrative, core competencies, differentiators, and past performance summaries tailored to your niche.</p>
              </div>              
            </div>
          </BaseCard>
        </NuxtLink>

        <!-- Opportunity Identification and Market Intelligence -->
        <NuxtLink to="/services/market-intelligence">
          <BaseCard fullHeight interactive padding="md" class="hover:shadow-medium transition-shadow">
            <div class="text-center">
              <IconWrapper icon="heroicons:magnifying-glass" variant="primary" size="lg" class="mx-auto mb-6" />
              <h3 class="text-xl font-bold text-secondary-900 mb-4">Opportunity Identification and Market Intelligence</h3>
              <p class="text-secondary-600 mb-6">
                Find and target the right opportunities before your competition.
              </p>
              <div class="text-left text-sm text-secondary-600 space-y-2 mb-6">
                <p class="font-medium">• Bid Matchmaking Services:</p>
                <p class="pl-4">We use premium intelligence tools to uncover relevant opportunities.</p>
                <p class="font-medium">• Opportunity Tracking:</p>
                <p class="pl-4">Stay ahead of new bids with regular updates on potential contracts aligned with your capabilities.</p>
                <p class="font-medium">• Strategic Targeting Plans:</p>
                <p class="pl-4">Focus your efforts on winnable opportunities with higher return on investment.</p>
              </div>              
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
                From RFP to submission — we manage the full proposal lifecycle.
              </p>
              <div class="text-left text-sm text-secondary-600 space-y-2 mb-6">
                <p class="font-medium">• Proposal Writing & Management:</p>
                <p class="pl-4">Complete support for responding to RFPs/RFQs at both the state and federal levels.</p>
                <p class="font-medium">• Bid/No-Bid Strategy:</p>
                <p class="pl-4">We help you assess which opportunities are worth pursuing—saving you time and increasing win probability.</p>
                <p class="font-medium">• Submission Support & Formatting:</p>
                <p class="pl-4">Ensure your proposal is professionally formatted, complete, and compliant with all solicitation requirements.</p>
              </div>              
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
                Navigate the FAR and state-specific requirements with confidence.
              </p>
              <div class="text-left text-sm text-secondary-600 space-y-2 mb-6">
                <p class="font-medium">• FAR Compliance Consulting:</p>
                <p class="pl-4">Interpret, apply, and integrate Federal Acquisition Regulations into your processes.</p>
                <p class="font-medium">• Contract Risk Mitigation:</p>
                <p class="pl-4">Avoid costly mistakes with expert guidance on regulatory traps, certifications, and performance clauses.</p>
                <p class="font-medium">• Bonding Guidance:</p>
                <p class="pl-4">Understand and meet bonding requirements to qualify for public sector contracts.</p>
              </div>              
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
                Equip your team with the knowledge to compete and win.
              </p>
              <div class="text-left text-sm text-secondary-600 space-y-2 mb-6">
                <p class="font-medium">• Customized Government Contracting Training:</p>
                <p class="pl-4">In-person or virtual sessions tailored to your business and team needs.</p>
                <p class="font-medium">• Proposal Writing Best Practices:</p>
                <p class="pl-4">Improve your internal capacity to respond to opportunities with in-house skill development.</p>
                <p class="font-medium">• Procurement Systems Navigation:</p>
                <p class="pl-4">Learn how to effectively use platforms like SAM.gov, eBuy, FPDS, and more.</p>
              </div>              
            </div>
          </BaseCard>
        </NuxtLink>
      </div>
    </BaseSection>

    <!-- Process Overview -->
    <BaseSection variant="secondary" title="Our Process" subtitle="A structured approach to federal contracting success"
      spacing="lg">
      <div class="grid grid-cols-1 md:grid-cols-4 gap-8">
        <!-- Step 1 -->
        <div class="text-center">
          <div
            class="flex items-center justify-center w-16 h-16 bg-primary-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
            1
          </div>
          <h3 class="text-lg font-semibold text-secondary-900 mb-3">Assessment</h3>
          <p class="text-secondary-600 text-sm">
            Evaluate your business readiness and identify opportunities for federal contracting success.
          </p>
        </div>

        <!-- Step 2 -->
        <div class="text-center">
          <div
            class="flex items-center justify-center w-16 h-16 bg-primary-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
            2
          </div>
          <h3 class="text-lg font-semibold text-secondary-900 mb-3">Strategy</h3>
          <p class="text-secondary-600 text-sm">
            Develop a customized strategy based on your capabilities, market opportunities, and business goals.
          </p>
        </div>

        <!-- Step 3 -->
        <div class="text-center">
          <div
            class="flex items-center justify-center w-16 h-16 bg-primary-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
            3
          </div>
          <h3 class="text-lg font-semibold text-secondary-900 mb-3">Implementation</h3>
          <p class="text-secondary-600 text-sm">
            Execute the strategy with hands-on support for registrations, certifications, and compliance setup.
          </p>
        </div>

        <!-- Step 4 -->
        <div class="text-center">
          <div
            class="flex items-center justify-center w-16 h-16 bg-primary-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
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
        <h2 class="text-3xl text-center font-bold text-white mb-4">
          Ready to Start Your Federal Contracting Journey?
        </h2>
        <p class="text-xl text-center text-primary-100 mb-8 max-w-2xl mx-auto">
          Schedule a consultation to discuss your business goals and learn how we can help you succeed in federal
          contracting.
        </p>
      </template>

      <div class="flex flex-col sm:flex-row justify-center items-center space-y-4 sm:space-y-0 sm:space-x-4">
        <BaseButton variant="secondary" size="lg" icon-left="heroicons:calendar-days">
          <NuxtLink to="/contact">
            Schedule Consultation
          </NuxtLink>
        </BaseButton>
        <BaseButton variant="secondary" size="lg" icon-left="heroicons:book-open">
          <NuxtLink to="/resources">
            Explore Resources
          </NuxtLink>
        </BaseButton>
      </div>
    </BaseSection>
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