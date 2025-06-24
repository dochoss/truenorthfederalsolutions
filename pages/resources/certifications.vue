<template>
  <div>
    <NavSection />
    
    <!-- Certifications Header -->
    <section class="bg-purple-50 py-16">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <Icon name="heroicons:trophy" class="w-16 h-16 text-purple-700 mx-auto mb-6" />
        <h1 class="text-4xl font-bold text-gray-900 mb-4">
          Small Business Certification Help
        </h1>
        <p class="text-xl text-gray-600 max-w-2xl mx-auto">
          Get guidance on WOSB, VOSB, 8(a), and other certifications to maximize your federal contracting opportunities and competitive advantages.
        </p>
      </div>
    </section>

    <!-- Certification Benefits -->
    <section class="py-16 bg-white">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Why Small Business Certifications Matter
          </h2>
          <p class="text-lg text-gray-600 max-w-3xl mx-auto">
            Federal agencies have goals to award a percentage of their contracts to small businesses with specific certifications. These set-asides can significantly reduce competition and increase your win probability.
          </p>
        </div>

        <div class="grid grid-cols-1 md:grid-cols-3 gap-8">
          <!-- Benefit 1 -->
          <div class="text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-purple-100 rounded-lg mx-auto mb-4">
              <Icon name="heroicons:user-group" class="w-8 h-8 text-purple-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Reduced Competition</h3>
            <p class="text-gray-600 text-sm">
              Set-aside contracts are only open to certified small businesses, dramatically reducing the number of competitors.
            </p>
          </div>

          <!-- Benefit 2 -->
          <div class="text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-green-100 rounded-lg mx-auto mb-4">
              <Icon name="heroicons:target" class="w-8 h-8 text-green-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Higher Win Rates</h3>
            <p class="text-gray-600 text-sm">
              Agencies must meet small business contracting goals, creating more opportunities for certified businesses.
            </p>
          </div>

          <!-- Benefit 3 -->
          <div class="text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-blue-100 rounded-lg mx-auto mb-4">
              <Icon name="heroicons:currency-dollar" class="w-8 h-8 text-blue-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Access to More Opportunities</h3>
            <p class="text-gray-600 text-sm">
              Billions of dollars in federal contracts are set aside specifically for small business programs.
            </p>
          </div>
        </div>
      </div>
    </section>

    <!-- Certification Programs -->
    <section class="py-16 bg-gray-50">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Small Business Certification Programs
          </h2>
          <p class="text-lg text-gray-600">
            Explore the major certification programs and their requirements
          </p>
        </div>

        <div class="grid grid-cols-1 md:grid-cols-2 gap-8">
          <!-- WOSB -->
          <div class="bg-white rounded-lg p-8 shadow-sm hover:shadow-md transition-shadow">
            <div class="flex items-center mb-6">
              <div class="flex items-center justify-center w-12 h-12 bg-pink-100 rounded-lg mr-4">
                <Icon name="heroicons:user-circle" class="w-6 h-6 text-pink-700" />
              </div>
              <div>
                <h3 class="text-xl font-bold text-gray-900">WOSB Certification</h3>
                <p class="text-gray-600 text-sm">Woman-Owned Small Business</p>
              </div>
            </div>
            <p class="text-gray-600 mb-4">
              For businesses that are at least 51% owned and controlled by women. Provides access to federal set-aside contracts worth billions annually.
            </p>
            <ul class="text-sm text-gray-600 space-y-2 mb-6">
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>51% ownership by women</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>Day-to-day management control</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>Meet SBA size standards</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>U.S. citizenship required</span>
              </li>
            </ul>
            <div class="flex justify-between items-center">
              <NuxtLink 
                to="/resources/certifications/wosb"
                class="text-purple-700 hover:text-purple-800 font-medium text-sm"
              >
                Learn More →
              </NuxtLink>
              <span class="text-xs text-gray-500">$25B+ set aside annually</span>
            </div>
          </div>

          <!-- VOSB -->
          <div class="bg-white rounded-lg p-8 shadow-sm hover:shadow-md transition-shadow">
            <div class="flex items-center mb-6">
              <div class="flex items-center justify-center w-12 h-12 bg-blue-100 rounded-lg mr-4">
                <Icon name="heroicons:star" class="w-6 h-6 text-blue-700" />
              </div>
              <div>
                <h3 class="text-xl font-bold text-gray-900">VOSB Certification</h3>
                <p class="text-gray-600 text-sm">Veteran-Owned Small Business</p>
              </div>
            </div>
            <p class="text-gray-600 mb-4">
              For businesses owned and controlled by veterans. Includes both VOSB and SDVOSB (Service-Disabled Veteran-Owned) programs.
            </p>
            <ul class="text-sm text-gray-600 space-y-2 mb-6">
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>51% veteran ownership</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>Veteran control of management</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>Honorable discharge required</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>SDVOSB for disabled veterans</span>
              </li>
            </ul>
            <div class="flex justify-between items-center">
              <NuxtLink 
                to="/resources/certifications/vosb"
                class="text-purple-700 hover:text-purple-800 font-medium text-sm"
              >
                Learn More →
              </NuxtLink>
              <span class="text-xs text-gray-500">3% federal contracting goal</span>
            </div>
          </div>

          <!-- 8(a) Program -->
          <div class="bg-white rounded-lg p-8 shadow-sm hover:shadow-md transition-shadow">
            <div class="flex items-center mb-6">
              <div class="flex items-center justify-center w-12 h-12 bg-green-100 rounded-lg mr-4">
                <Icon name="heroicons:academic-cap" class="w-6 h-6 text-green-700" />
              </div>
              <div>
                <h3 class="text-xl font-bold text-gray-900">8(a) Business Development</h3>
                <p class="text-gray-600 text-sm">Socially & Economically Disadvantaged</p>
              </div>
            </div>
            <p class="text-gray-600 mb-4">
              9-year program for socially and economically disadvantaged business owners, providing extensive business development assistance.
            </p>
            <ul class="text-sm text-gray-600 space-y-2 mb-6">
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>Social disadvantage criteria</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>Economic disadvantage limits</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>51% ownership requirement</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>Annual reviews required</span>
              </li>
            </ul>
            <div class="flex justify-between items-center">
              <NuxtLink 
                to="/resources/certifications/8a"
                class="text-purple-700 hover:text-purple-800 font-medium text-sm"
              >
                Learn More →
              </NuxtLink>
              <span class="text-xs text-gray-500">Sole source up to $4.5M</span>
            </div>
          </div>

          <!-- HUBZone -->
          <div class="bg-white rounded-lg p-8 shadow-sm hover:shadow-md transition-shadow">
            <div class="flex items-center mb-6">
              <div class="flex items-center justify-center w-12 h-12 bg-orange-100 rounded-lg mr-4">
                <Icon name="heroicons:map-pin" class="w-6 h-6 text-orange-700" />
              </div>
              <div>
                <h3 class="text-xl font-bold text-gray-900">HUBZone Certification</h3>
                <p class="text-gray-600 text-sm">Historically Underutilized Business Zone</p>
              </div>
            </div>
            <p class="text-gray-600 mb-4">
              For businesses located in historically underutilized business zones, promoting economic development in distressed areas.
            </p>
            <ul class="text-sm text-gray-600 space-y-2 mb-6">
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>Located in qualified HUBZone</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>35% employees in HUBZone</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>Principal office in HUBZone</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>51% ownership requirement</span>
              </li>
            </ul>
            <div class="flex justify-between items-center">
              <span class="text-gray-500 text-sm">Detailed guide coming soon</span>
              <span class="text-xs text-gray-500">3% federal contracting goal</span>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- Certification Process -->
    <section class="py-16 bg-white">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            General Certification Process
          </h2>
          <p class="text-lg text-gray-600">
            While each program has specific requirements, the general process is similar
          </p>
        </div>

        <div class="grid grid-cols-1 md:grid-cols-4 gap-8">
          <!-- Step 1 -->
          <div class="text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-purple-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
              1
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Determine Eligibility</h3>
            <p class="text-gray-600 text-sm">
              Review program requirements to ensure you meet ownership, control, and other eligibility criteria.
            </p>
          </div>

          <!-- Step 2 -->
          <div class="text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-purple-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
              2
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Gather Documentation</h3>
            <p class="text-gray-600 text-sm">
              Collect required documents including financial statements, tax returns, and organizational documents.
            </p>
          </div>

          <!-- Step 3 -->
          <div class="text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-purple-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
              3
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Submit Application</h3>
            <p class="text-gray-600 text-sm">
              Complete application through appropriate channels (SAM.gov, SBA, or third-party certifiers).
            </p>
          </div>

          <!-- Step 4 -->
          <div class="text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-purple-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
              4
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Maintain Certification</h3>
            <p class="text-gray-600 text-sm">
              Meet ongoing requirements, submit annual updates, and renew certifications as required.
            </p>
          </div>
        </div>
      </div>
    </section>

    <!-- Common Mistakes -->
    <section class="py-16 bg-gray-50">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Common Certification Mistakes to Avoid
          </h2>
          <p class="text-lg text-gray-600">
            Learn from others' mistakes to ensure your certification is successful
          </p>
        </div>

        <div class="grid grid-cols-1 md:grid-cols-2 gap-8">
          <!-- Mistake 1 -->
          <div class="bg-white rounded-lg p-6 border-l-4 border-red-500">
            <div class="flex items-start space-x-4">
              <Icon name="heroicons:exclamation-triangle" class="w-6 h-6 text-red-500 mt-1" />
              <div>
                <h3 class="text-lg font-semibold text-gray-900 mb-2">Incomplete Documentation</h3>
                <p class="text-gray-600 text-sm">
                  Failing to provide all required documents or submitting incomplete financial information can result in denial or delays.
                </p>
              </div>
            </div>
          </div>

          <!-- Mistake 2 -->
          <div class="bg-white rounded-lg p-6 border-l-4 border-red-500">
            <div class="flex items-start space-x-4">
              <Icon name="heroicons:exclamation-triangle" class="w-6 h-6 text-red-500 mt-1" />
              <div>
                <h3 class="text-lg font-semibold text-gray-900 mb-2">Ownership Structure Issues</h3>
                <p class="text-gray-600 text-sm">
                  Complex ownership structures or inadequate control by the qualifying individual can disqualify applications.
                </p>
              </div>
            </div>
          </div>

          <!-- Mistake 3 -->
          <div class="bg-white rounded-lg p-6 border-l-4 border-yellow-500">
            <div class="flex items-start space-x-4">
              <Icon name="heroicons:exclamation-triangle" class="w-6 h-6 text-yellow-500 mt-1" />
              <div>
                <h3 class="text-lg font-semibold text-gray-900 mb-2">Size Standard Violations</h3>
                <p class="text-gray-600 text-sm">
                  Exceeding SBA size standards for your NAICS codes can disqualify you from small business programs.
                </p>
              </div>
            </div>
          </div>

          <!-- Mistake 4 -->
          <div class="bg-white rounded-lg p-6 border-l-4 border-yellow-500">
            <div class="flex items-start space-x-4">
              <Icon name="heroicons:exclamation-triangle" class="w-6 h-6 text-yellow-500 mt-1" />
              <div>
                <h3 class="text-lg font-semibold text-gray-900 mb-2">Inadequate Maintenance</h3>
                <p class="text-gray-600 text-sm">
                  Failing to update certifications annually or not reporting material changes can result in decertification.
                </p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- CTA Section -->
    <section class="py-16 bg-purple-700 text-white">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <h2 class="text-3xl font-bold mb-4">
          Ready to Get Certified?
        </h2>
        <p class="text-xl mb-8 opacity-90">
          Don't navigate the certification process alone. Get expert guidance to ensure your application is successful and compliant.
        </p>
        <div class="flex flex-col sm:flex-row justify-center space-y-4 sm:space-y-0 sm:space-x-4">
          <NuxtLink 
            to="/contact"
            class="inline-flex items-center justify-center px-8 py-3 bg-white text-purple-700 rounded-md hover:bg-gray-100 transition-colors font-medium"
          >
            <Icon name="heroicons:calendar-days" class="w-5 h-5 mr-2" />
            Schedule Consultation
          </NuxtLink>
          <NuxtLink 
            to="/resources/guides"
            class="inline-flex items-center justify-center px-8 py-3 border border-white text-white rounded-md hover:bg-purple-600 transition-colors font-medium"
          >
            <Icon name="heroicons:document-arrow-down" class="w-5 h-5 mr-2" />
            Download Guides
          </NuxtLink>
        </div>
      </div>
    </section>
  </div>
</template>

<script setup>
// Set page meta for SEO
definePageMeta({
  title: 'Certification Help - True North Federal Solutions',
  description: 'Expert guidance on small business certifications including WOSB, VOSB, 8(a), and HUBZone programs for federal contracting success.'
})

// Set head for SEO
useHead({
  title: 'Small Business Certification Help - True North Federal Solutions',
  meta: [
    { 
      name: 'description', 
      content: 'Get help with WOSB, VOSB, 8(a), and HUBZone certifications. Expert guidance on requirements, application process, and maintaining certifications.' 
    },
    { 
      name: 'keywords', 
      content: 'WOSB certification, VOSB certification, 8a program, HUBZone, small business certifications, woman owned small business, veteran owned' 
    }
  ]
})
</script>