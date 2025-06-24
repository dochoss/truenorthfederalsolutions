<template>
  <div>
    <NavSection />
    
    <!-- Service Header -->
    <section class="bg-orange-50 py-16">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <Icon name="heroicons:shield-check" class="w-16 h-16 text-orange-700 mx-auto mb-6" />
        <h1 class="text-4xl font-bold text-gray-900 mb-4">
          FAR Compliance Consulting
        </h1>
        <p class="text-xl text-gray-600 max-w-2xl mx-auto">
          Ensure your business meets all Federal Acquisition Regulation requirements with expert guidance and ongoing support from experienced contracting professionals.
        </p>
      </div>
    </section>

    <!-- Service Details -->
    <section class="py-16 bg-white">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="prose prose-lg max-w-none">
          <h2 class="text-2xl font-bold text-gray-900 mb-6">
            Navigate Complex FAR Requirements with Confidence
          </h2>
          <p class="text-gray-600 mb-8">
            The Federal Acquisition Regulation (FAR) is complex and constantly evolving. Non-compliance can result in contract termination, debarment, or significant financial penalties. Our FAR compliance consulting ensures your business operates within federal requirements while maintaining competitive advantages.
          </p>

          <div class="grid grid-cols-1 md:grid-cols-2 gap-8 mb-12">
            <!-- What's Included -->
            <div>
              <h3 class="text-xl font-semibold text-gray-900 mb-4">What's Included</h3>
              <ul class="space-y-3 text-gray-600">
                <li class="flex items-start">
                  <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mr-3 mt-0.5" />
                  <span>Comprehensive compliance audit and assessment</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mr-3 mt-0.5" />
                  <span>FAR training and education programs</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mr-3 mt-0.5" />
                  <span>Policy and procedure development</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mr-3 mt-0.5" />
                  <span>Documentation and record-keeping systems</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mr-3 mt-0.5" />
                  <span>Ongoing compliance monitoring</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mr-3 mt-0.5" />
                  <span>Risk assessment and mitigation strategies</span>
                </li>
              </ul>
            </div>

            <!-- Benefits -->
            <div>
              <h3 class="text-xl font-semibold text-gray-900 mb-4">Benefits</h3>
              <ul class="space-y-3 text-gray-600">
                <li class="flex items-start">
                  <Icon name="heroicons:star" class="w-5 h-5 text-yellow-500 mr-3 mt-0.5" />
                  <span>Avoid costly compliance violations</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:star" class="w-5 h-5 text-yellow-500 mr-3 mt-0.5" />
                  <span>Reduce audit and investigation risk</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:star" class="w-5 h-5 text-yellow-500 mr-3 mt-0.5" />
                  <span>Maintain competitive eligibility</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:star" class="w-5 h-5 text-yellow-500 mr-3 mt-0.5" />
                  <span>Build sustainable compliance culture</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:star" class="w-5 h-5 text-yellow-500 mr-3 mt-0.5" />
                  <span>Expert contracting officer guidance</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:star" class="w-5 h-5 text-yellow-500 mr-3 mt-0.5" />
                  <span>Peace of mind and confidence</span>
                </li>
              </ul>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- Compliance Areas -->
    <section class="py-16 bg-gray-50">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Key Compliance Areas We Address
          </h2>
          <p class="text-lg text-gray-600">
            Comprehensive coverage of critical FAR compliance requirements
          </p>
        </div>

        <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-8">
          <!-- Cost Accounting -->
          <div class="bg-white rounded-lg p-6 shadow-sm">
            <div class="flex items-center justify-center w-12 h-12 bg-orange-100 rounded-lg mb-4">
              <Icon name="heroicons:calculator" class="w-6 h-6 text-orange-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Cost Accounting Standards</h3>
            <p class="text-gray-600 text-sm">
              CAS compliance, cost allocation, and accounting system requirements for government contractors.
            </p>
          </div>

          <!-- Truth in Negotiations -->
          <div class="bg-white rounded-lg p-6 shadow-sm">
            <div class="flex items-center justify-center w-12 h-12 bg-blue-100 rounded-lg mb-4">
              <Icon name="heroicons:scale" class="w-6 h-6 text-blue-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Truth in Negotiations Act</h3>
            <p class="text-gray-600 text-sm">
              TINA compliance, certified cost or pricing data, and defective pricing prevention.
            </p>
          </div>

          <!-- Buy American -->
          <div class="bg-white rounded-lg p-6 shadow-sm">
            <div class="flex items-center justify-center w-12 h-12 bg-green-100 rounded-lg mb-4">
              <Icon name="heroicons:flag" class="w-6 h-6 text-green-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Buy American Act</h3>
            <p class="text-gray-600 text-sm">
              Domestic preference requirements, country of origin determinations, and waiver processes.
            </p>
          </div>

          <!-- Service Contract Act -->
          <div class="bg-white rounded-lg p-6 shadow-sm">
            <div class="flex items-center justify-center w-12 h-12 bg-purple-100 rounded-lg mb-4">
              <Icon name="heroicons:user-group" class="w-6 h-6 text-purple-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Service Contract Act</h3>
            <p class="text-gray-600 text-sm">
              SCA wage determinations, fringe benefits, and service contract labor standards compliance.
            </p>
          </div>

          <!-- Davis-Bacon -->
          <div class="bg-white rounded-lg p-6 shadow-sm">
            <div class="flex items-center justify-center w-12 h-12 bg-red-100 rounded-lg mb-4">
              <Icon name="heroicons:wrench-screwdriver" class="w-6 h-6 text-red-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Davis-Bacon Act</h3>
            <p class="text-gray-600 text-sm">
              Prevailing wage requirements for construction contracts and certified payroll reporting.
            </p>
          </div>

          <!-- Security Requirements -->
          <div class="bg-white rounded-lg p-6 shadow-sm">
            <div class="flex items-center justify-center w-12 h-12 bg-indigo-100 rounded-lg mb-4">
              <Icon name="heroicons:lock-closed" class="w-6 h-6 text-indigo-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Security Requirements</h3>
            <p class="text-gray-600 text-sm">
              Personnel security clearances, facility security clearances, and classified information handling.
            </p>
          </div>
        </div>
      </div>
    </section>

    <!-- Process Overview -->
    <section class="py-16 bg-white">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Our Compliance Process
          </h2>
          <p class="text-lg text-gray-600">
            Systematic approach to achieving and maintaining FAR compliance
          </p>
        </div>

        <div class="grid grid-cols-1 md:grid-cols-4 gap-8">
          <!-- Phase 1 -->
          <div class="text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-orange-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
              1
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Assessment</h3>
            <p class="text-gray-600 text-sm">
              Comprehensive audit of current compliance status, identification of gaps, and risk assessment.
            </p>
          </div>

          <!-- Phase 2 -->
          <div class="text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-orange-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
              2
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Planning</h3>
            <p class="text-gray-600 text-sm">
              Development of compliance roadmap, policies, procedures, and training programs tailored to your business.
            </p>
          </div>

          <!-- Phase 3 -->
          <div class="text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-orange-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
              3
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Implementation</h3>
            <p class="text-gray-600 text-sm">
              Execute compliance improvements, train staff, and establish monitoring and reporting systems.
            </p>
          </div>

          <!-- Phase 4 -->
          <div class="text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-orange-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
              4
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Monitoring</h3>
            <p class="text-gray-600 text-sm">
              Ongoing compliance monitoring, updates for regulatory changes, and continuous improvement support.
            </p>
          </div>
        </div>
      </div>
    </section>

    <!-- Risk Areas -->
    <section class="py-16 bg-gray-50">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Common Compliance Risk Areas
          </h2>
          <p class="text-lg text-gray-600">
            Areas where contractors frequently encounter compliance challenges
          </p>
        </div>

        <div class="grid grid-cols-1 md:grid-cols-2 gap-8">
          <!-- Risk Card 1 -->
          <div class="bg-white rounded-lg p-6 shadow-sm border-l-4 border-red-500">
            <div class="flex items-start space-x-4">
              <Icon name="heroicons:exclamation-triangle" class="w-8 h-8 text-red-500 mt-1" />
              <div>
                <h3 class="text-lg font-semibold text-gray-900 mb-2">Cost Mischarging</h3>
                <p class="text-gray-600 text-sm mb-3">
                  Improper allocation of costs between contracts, overhead pools, or business units can lead to False Claims Act violations.
                </p>
                <p class="text-orange-700 text-sm font-medium">High Risk - Criminal and Civil Penalties</p>
              </div>
            </div>
          </div>

          <!-- Risk Card 2 -->
          <div class="bg-white rounded-lg p-6 shadow-sm border-l-4 border-red-500">
            <div class="flex items-start space-x-4">
              <Icon name="heroicons:exclamation-triangle" class="w-8 h-8 text-red-500 mt-1" />
              <div>
                <h3 class="text-lg font-semibold text-gray-900 mb-2">Defective Pricing</h3>
                <p class="text-gray-600 text-sm mb-3">
                  Failure to disclose current, accurate, and complete cost or pricing data when required by TINA.
                </p>
                <p class="text-orange-700 text-sm font-medium">High Risk - Price Adjustments and Penalties</p>
              </div>
            </div>
          </div>

          <!-- Risk Card 3 -->
          <div class="bg-white rounded-lg p-6 shadow-sm border-l-4 border-yellow-500">
            <div class="flex items-start space-x-4">
              <Icon name="heroicons:exclamation-triangle" class="w-8 h-8 text-yellow-500 mt-1" />
              <div>
                <h3 class="text-lg font-semibold text-gray-900 mb-2">Small Business Misrepresentation</h3>
                <p class="text-gray-600 text-sm mb-3">
                  Inaccurate size certification or status misrepresentation can result in contract termination and debarment.
                </p>
                <p class="text-orange-700 text-sm font-medium">Medium Risk - Contract Termination</p>
              </div>
            </div>
          </div>

          <!-- Risk Card 4 -->
          <div class="bg-white rounded-lg p-6 shadow-sm border-l-4 border-yellow-500">
            <div class="flex items-start space-x-4">
              <Icon name="heroicons:exclamation-triangle" class="w-8 h-8 text-yellow-500 mt-1" />
              <div>
                <h3 class="text-lg font-semibold text-gray-900 mb-2">Labor Law Violations</h3>
                <p class="text-gray-600 text-sm mb-3">
                  Non-compliance with SCA, Davis-Bacon, or other labor standards can result in back wages and penalties.
                </p>
                <p class="text-orange-700 text-sm font-medium">Medium Risk - Back Wages and Fines</p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- CTA Section -->
    <section class="py-16 bg-orange-700 text-white">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <h2 class="text-3xl font-bold mb-4">
          Don't Risk Your Federal Contracting Future
        </h2>
        <p class="text-xl mb-8 opacity-90">
          FAR compliance is not optional. Get expert guidance to protect your business and maintain your competitive position in the federal marketplace.
        </p>
        <div class="flex flex-col sm:flex-row justify-center space-y-4 sm:space-y-0 sm:space-x-4">
          <NuxtLink 
            to="/contact"
            class="inline-flex items-center justify-center px-8 py-3 bg-white text-orange-700 rounded-md hover:bg-gray-100 transition-colors font-medium"
          >
            <Icon name="heroicons:calendar-days" class="w-5 h-5 mr-2" />
            Schedule Compliance Assessment
          </NuxtLink>
          <NuxtLink 
            to="/services"
            class="inline-flex items-center justify-center px-8 py-3 border border-white text-white rounded-md hover:bg-orange-600 transition-colors font-medium"
          >
            <Icon name="heroicons:arrow-left" class="w-5 h-5 mr-2" />
            All Services
          </NuxtLink>
        </div>
      </div>
    </section>
  </div>
</template>

<script setup>
// Set page meta for SEO
definePageMeta({
  title: 'FAR Compliance Consulting - True North Federal Solutions',
  description: 'Expert FAR compliance consulting services to ensure your federal contracting business meets all regulatory requirements and avoids costly violations.'
})

// Set head for SEO
useHead({
  title: 'FAR Compliance Consulting - True North Federal Solutions',
  meta: [
    { 
      name: 'description', 
      content: 'Professional FAR compliance consulting from experienced contracting officers. Cost accounting, TINA, Buy American, SCA, and security requirements.' 
    },
    { 
      name: 'keywords', 
      content: 'FAR compliance, federal acquisition regulation, cost accounting standards, TINA compliance, government contractor compliance' 
    }
  ]
})
</script>