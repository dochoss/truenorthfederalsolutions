<template>
  <div>
    <NavSection />
    
    <!-- Services Header -->
    <section class="bg-blue-50 py-16">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <Icon name="heroicons:briefcase" class="w-16 h-16 text-blue-700 mx-auto mb-6" />
        <h1 class="text-4xl font-bold text-gray-900 mb-4">
          Federal Contracting Services
        </h1>
        <p class="text-xl text-gray-600 max-w-2xl mx-auto">
          Expert guidance to navigate the complex world of federal contracting. From initial setup to proposal development, we're here to help your business succeed.
        </p>
      </div>
    </section>

    <!-- Services Overview -->
    <section class="py-16 bg-white">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Comprehensive Federal Contracting Support
          </h2>
          <p class="text-lg text-gray-600 max-w-3xl mx-auto">
            With 15 years of federal service experience, from GS-06 to Contracting Officer, we provide the expertise you need to successfully navigate federal procurement.
          </p>
        </div>

        <!-- Service Cards -->
        <div class="grid grid-cols-1 md:grid-cols-2 gap-8 mb-12">
          <!-- Federal Contract Setup -->
          <div class="bg-gray-50 rounded-lg p-8 hover:shadow-lg transition-shadow">
            <div class="flex items-center justify-center w-16 h-16 bg-blue-100 rounded-lg mb-6">
              <Icon name="heroicons:document-text" class="w-8 h-8 text-blue-700" />
            </div>
            <h3 class="text-xl font-bold text-gray-900 mb-4">Federal Contract Setup</h3>
            <p class="text-gray-600 mb-6">
              Get your business ready for federal contracting with proper registrations, certifications, and compliance foundation.
            </p>
            <ul class="text-sm text-gray-600 space-y-2 mb-6">
              <li>• SAM.gov registration and maintenance</li>
              <li>• CAGE code acquisition</li>
              <li>• NAICS code selection and strategy</li>
              <li>• Small business certifications (WOSB, VOSB, 8a)</li>
              <li>• Compliance systems setup</li>
            </ul>
            <NuxtLink 
              to="/services/contract-setup"
              class="inline-flex items-center text-blue-700 hover:text-blue-800 font-medium"
            >
              Learn More
              <Icon name="heroicons:arrow-right" class="w-4 h-4 ml-2" />
            </NuxtLink>
          </div>

          <!-- Proposal Development -->
          <div class="bg-gray-50 rounded-lg p-8 hover:shadow-lg transition-shadow">
            <div class="flex items-center justify-center w-16 h-16 bg-green-100 rounded-lg mb-6">
              <Icon name="heroicons:pencil-square" class="w-8 h-8 text-green-700" />
            </div>
            <h3 class="text-xl font-bold text-gray-900 mb-4">Proposal Development</h3>
            <p class="text-gray-600 mb-6">
              Craft winning proposals with strategic guidance from an experienced contracting officer perspective.
            </p>
            <ul class="text-sm text-gray-600 space-y-2 mb-6">
              <li>• Opportunity analysis and strategy</li>
              <li>• Proposal writing and review</li>
              <li>• Technical and price evaluation</li>
              <li>• Past performance documentation</li>
              <li>• Submission support and follow-up</li>
            </ul>
            <NuxtLink 
              to="/services/proposal-development"
              class="inline-flex items-center text-blue-700 hover:text-blue-800 font-medium"
            >
              Learn More
              <Icon name="heroicons:arrow-right" class="w-4 h-4 ml-2" />
            </NuxtLink>
          </div>

          <!-- FAR Compliance -->
          <div class="bg-gray-50 rounded-lg p-8 hover:shadow-lg transition-shadow">
            <div class="flex items-center justify-center w-16 h-16 bg-orange-100 rounded-lg mb-6">
              <Icon name="heroicons:shield-check" class="w-8 h-8 text-orange-700" />
            </div>
            <h3 class="text-xl font-bold text-gray-900 mb-4">FAR Compliance Consulting</h3>
            <p class="text-gray-600 mb-6">
              Ensure your business meets all Federal Acquisition Regulation requirements with expert guidance and ongoing support.
            </p>
            <ul class="text-sm text-gray-600 space-y-2 mb-6">
              <li>• FAR compliance audits and assessments</li>
              <li>• Training and education programs</li>
              <li>• Documentation and process setup</li>
              <li>• Ongoing compliance monitoring</li>
              <li>• Risk assessment and mitigation</li>
            </ul>
            <NuxtLink 
              to="/services/far-compliance"
              class="inline-flex items-center text-blue-700 hover:text-blue-800 font-medium"
            >
              Learn More
              <Icon name="heroicons:arrow-right" class="w-4 h-4 ml-2" />
            </NuxtLink>
          </div>

          <!-- Bid/No-Bid Strategy -->
          <div class="bg-gray-50 rounded-lg p-8 hover:shadow-lg transition-shadow">
            <div class="flex items-center justify-center w-16 h-16 bg-purple-100 rounded-lg mb-6">
              <Icon name="heroicons:chart-bar" class="w-8 h-8 text-purple-700" />
            </div>
            <h3 class="text-xl font-bold text-gray-900 mb-4">Bid/No-Bid Strategy</h3>
            <p class="text-gray-600 mb-6">
              Make informed decisions about which opportunities to pursue with strategic analysis and win probability assessment.
            </p>
            <ul class="text-sm text-gray-600 space-y-2 mb-6">
              <li>• Opportunity analysis and evaluation</li>
              <li>• Win probability assessment</li>
              <li>• Resource requirement analysis</li>
              <li>• ROI projections and modeling</li>
              <li>• Strategic recommendations</li>
            </ul>
            <NuxtLink 
              to="/services/bid-no-bid-strategy"
              class="inline-flex items-center text-blue-700 hover:text-blue-800 font-medium"
            >
              Learn More
              <Icon name="heroicons:arrow-right" class="w-4 h-4 ml-2" />
            </NuxtLink>
          </div>
        </div>
      </div>
    </section>

    <!-- Process Overview -->
    <section class="py-16 bg-gray-50">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Our Process
          </h2>
          <p class="text-lg text-gray-600 max-w-2xl mx-auto">
            A structured approach to federal contracting success
          </p>
        </div>

        <div class="grid grid-cols-1 md:grid-cols-4 gap-8">
          <!-- Step 1 -->
          <div class="text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-blue-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
              1
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Assessment</h3>
            <p class="text-gray-600 text-sm">
              Evaluate your business readiness and identify opportunities for federal contracting success.
            </p>
          </div>

          <!-- Step 2 -->
          <div class="text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-blue-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
              2
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Strategy</h3>
            <p class="text-gray-600 text-sm">
              Develop a customized strategy based on your capabilities, market opportunities, and business goals.
            </p>
          </div>

          <!-- Step 3 -->
          <div class="text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-blue-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
              3
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Implementation</h3>
            <p class="text-gray-600 text-sm">
              Execute the strategy with hands-on support for registrations, certifications, and compliance setup.
            </p>
          </div>

          <!-- Step 4 -->
          <div class="text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-blue-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
              4
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Success</h3>
            <p class="text-gray-600 text-sm">
              Ongoing support to help you win contracts and grow your federal business successfully.
            </p>
          </div>
        </div>
      </div>
    </section>

    <!-- CTA Section -->
    <section class="py-16 bg-blue-700 text-white">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <h2 class="text-3xl font-bold mb-4">
          Ready to Start Your Federal Contracting Journey?
        </h2>
        <p class="text-xl mb-8 opacity-90">
          Schedule a consultation to discuss your business goals and learn how we can help you succeed in federal contracting.
        </p>
        <div class="flex flex-col sm:flex-row justify-center space-y-4 sm:space-y-0 sm:space-x-4">
          <NuxtLink 
            to="/contact"
            class="inline-flex items-center justify-center px-8 py-3 bg-white text-blue-700 rounded-md hover:bg-gray-100 transition-colors font-medium"
          >
            <Icon name="heroicons:calendar-days" class="w-5 h-5 mr-2" />
            Schedule Consultation
          </NuxtLink>
          <NuxtLink 
            to="/resources"
            class="inline-flex items-center justify-center px-8 py-3 border border-white text-white rounded-md hover:bg-blue-600 transition-colors font-medium"
          >
            <Icon name="heroicons:book-open" class="w-5 h-5 mr-2" />
            Explore Resources
          </NuxtLink>
        </div>
      </div>
    </section>
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