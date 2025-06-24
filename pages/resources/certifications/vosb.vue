<template>
  <div>
    <NavSection />
    
    <!-- VOSB Header -->
    <section class="bg-blue-50 py-16">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <Icon name="heroicons:star" class="w-16 h-16 text-blue-700 mx-auto mb-6" />
        <h1 class="text-4xl font-bold text-gray-900 mb-4">
          VOSB Certification Guide
        </h1>
        <p class="text-xl text-gray-600 max-w-2xl mx-auto">
          Complete guide to Veteran-Owned Small Business certification, including VOSB and SDVOSB programs, requirements, and application strategies.
        </p>
      </div>
    </section>

    <!-- VOSB Overview -->
    <section class="py-16 bg-white">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="prose prose-lg max-w-none">
          <h2 class="text-2xl font-bold text-gray-900 mb-6">
            What is VOSB Certification?
          </h2>
          <p class="text-gray-600 mb-8">
            The Veteran-Owned Small Business (VOSB) program provides contracting opportunities for veteran entrepreneurs. This includes both VOSB and Service-Disabled Veteran-Owned Small Business (SDVOSB) certifications, with the federal government having a 3% contracting goal for veteran-owned businesses.
          </p>

          <div class="grid grid-cols-1 md:grid-cols-2 gap-8 mb-12">
            <!-- VOSB Benefits -->
            <div>
              <h3 class="text-xl font-semibold text-gray-900 mb-4">VOSB Benefits</h3>
              <ul class="space-y-3 text-gray-600">
                <li class="flex items-start">
                  <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mr-3 mt-0.5" />
                  <span>Access to VOSB set-aside contracts</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mr-3 mt-0.5" />
                  <span>Sole source awards up to $5 million</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mr-3 mt-0.5" />
                  <span>Enhanced networking opportunities</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mr-3 mt-0.5" />
                  <span>Access to VA and other agency programs</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mr-3 mt-0.5" />
                  <span>Priority in competitive contracting</span>
                </li>
              </ul>
            </div>

            <!-- SDVOSB Benefits -->
            <div>
              <h3 class="text-xl font-semibold text-gray-900 mb-4">SDVOSB Additional Benefits</h3>
              <ul class="space-y-3 text-gray-600">
                <li class="flex items-start">
                  <Icon name="heroicons:star" class="w-5 h-5 text-yellow-500 mr-3 mt-0.5" />
                  <span>SDVOSB set-aside contracts</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:star" class="w-5 h-5 text-yellow-500 mr-3 mt-0.5" />
                  <span>SDVOSB sole source up to $5 million</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:star" class="w-5 h-5 text-yellow-500 mr-3 mt-0.5" />
                  <span>Higher priority than VOSB</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:star" class="w-5 h-5 text-yellow-500 mr-3 mt-0.5" />
                  <span>VA VOSB verification benefits</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:star" class="w-5 h-5 text-yellow-500 mr-3 mt-0.5" />
                  <span>Special recognition and awards</span>
                </li>
              </ul>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- Program Types -->
    <section class="py-16 bg-gray-50">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Veteran Business Programs
          </h2>
          <p class="text-lg text-gray-600">
            Understanding the different veteran business certification options
          </p>
        </div>

        <div class="grid grid-cols-1 md:grid-cols-2 gap-8">
          <!-- VOSB -->
          <div class="bg-white rounded-lg p-8 shadow-sm">
            <div class="flex items-center mb-6">
              <div class="flex items-center justify-center w-12 h-12 bg-blue-100 rounded-lg mr-4">
                <Icon name="heroicons:identification" class="w-6 h-6 text-blue-700" />
              </div>
              <div>
                <h3 class="text-xl font-bold text-gray-900">VOSB</h3>
                <p class="text-gray-600 text-sm">Veteran-Owned Small Business</p>
              </div>
            </div>
            <p class="text-gray-600 mb-6">
              For small businesses that are at least 51% owned and controlled by veterans. Provides access to federal set-aside contracts and enhanced opportunities.
            </p>
            <div class="space-y-3">
              <div class="flex items-center">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2" />
                <span class="text-sm text-gray-600">51% veteran ownership</span>
              </div>
              <div class="flex items-center">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2" />
                <span class="text-sm text-gray-600">Honorable discharge required</span>
              </div>
              <div class="flex items-center">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2" />
                <span class="text-sm text-gray-600">Day-to-day management control</span>
              </div>
              <div class="flex items-center">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2" />
                <span class="text-sm text-gray-600">Meet SBA size standards</span>
              </div>
            </div>
          </div>

          <!-- SDVOSB -->
          <div class="bg-white rounded-lg p-8 shadow-sm border-l-4 border-yellow-500">
            <div class="flex items-center mb-6">
              <div class="flex items-center justify-center w-12 h-12 bg-yellow-100 rounded-lg mr-4">
                <Icon name="heroicons:star" class="w-6 h-6 text-yellow-700" />
              </div>
              <div>
                <h3 class="text-xl font-bold text-gray-900">SDVOSB</h3>
                <p class="text-gray-600 text-sm">Service-Disabled Veteran-Owned Small Business</p>
              </div>
            </div>
            <p class="text-gray-600 mb-6">
              For small businesses owned and controlled by service-disabled veterans. Includes all VOSB benefits plus additional preferences and opportunities.
            </p>
            <div class="space-y-3">
              <div class="flex items-center">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2" />
                <span class="text-sm text-gray-600">All VOSB requirements</span>
              </div>
              <div class="flex items-center">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2" />
                <span class="text-sm text-gray-600">Service-connected disability</span>
              </div>
              <div class="flex items-center">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2" />
                <span class="text-sm text-gray-600">VA disability letter required</span>
              </div>
              <div class="flex items-center">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2" />
                <span class="text-sm text-gray-600">Higher contracting priority</span>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- Eligibility Requirements -->
    <section class="py-16 bg-white">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Detailed Eligibility Requirements
          </h2>
          <p class="text-lg text-gray-600">
            Specific criteria that must be met for VOSB and SDVOSB certification
          </p>
        </div>

        <div class="space-y-8">
          <!-- Veteran Status -->
          <div class="bg-gray-50 rounded-lg p-8">
            <h3 class="text-xl font-bold text-gray-900 mb-6 flex items-center">
              <Icon name="heroicons:identification" class="w-6 h-6 text-blue-700 mr-3" />
              Veteran Status Requirements
            </h3>
            <div class="grid grid-cols-1 md:grid-cols-2 gap-6">
              <div>
                <h4 class="font-semibold text-gray-900 mb-3">Military Service</h4>
                <ul class="space-y-2 text-gray-600 text-sm">
                  <li>• Active duty in U.S. Armed Forces</li>
                  <li>• Army, Navy, Air Force, Marines, Coast Guard</li>
                  <li>• National Guard or Reserves (qualifying service)</li>
                  <li>• Minimum service requirements met</li>
                </ul>
              </div>
              <div>
                <h4 class="font-semibold text-gray-900 mb-3">Discharge Status</h4>
                <ul class="space-y-2 text-gray-600 text-sm">
                  <li>• Honorable discharge required</li>
                  <li>• General discharge under honorable conditions acceptable</li>
                  <li>• DD-214 or equivalent documentation required</li>
                  <li>• No dishonorable or bad conduct discharges</li>
                </ul>
              </div>
            </div>
          </div>

          <!-- Ownership & Control -->
          <div class="bg-gray-50 rounded-lg p-8">
            <h3 class="text-xl font-bold text-gray-900 mb-6 flex items-center">
              <Icon name="heroicons:building-office" class="w-6 h-6 text-green-700 mr-3" />
              Ownership & Control Requirements
            </h3>
            <div class="grid grid-cols-1 md:grid-cols-3 gap-6">
              <div>
                <h4 class="font-semibold text-gray-900 mb-3">Ownership</h4>
                <ul class="space-y-2 text-gray-600 text-sm">
                  <li>• 51% or more owned by veterans</li>
                  <li>• Ownership must be direct and unconditional</li>
                  <li>• Stock certificates or membership agreements</li>
                  <li>• Clear ownership documentation</li>
                </ul>
              </div>
              <div>
                <h4 class="font-semibold text-gray-900 mb-3">Control</h4>
                <ul class="space-y-2 text-gray-600 text-sm">
                  <li>• Day-to-day management by veterans</li>
                  <li>• Strategic decision-making authority</li>
                  <li>• Operational control of business</li>
                  <li>• Board of directors control</li>
                </ul>
              </div>
              <div>
                <h4 class="font-semibold text-gray-900 mb-3">Size Standards</h4>
                <ul class="space-y-2 text-gray-600 text-sm">
                  <li>• Meet SBA size standards</li>
                  <li>• Based on primary NAICS code</li>
                  <li>• Revenue or employee thresholds</li>
                  <li>• Affiliation rules apply</li>
                </ul>
              </div>
            </div>
          </div>

          <!-- SDVOSB Additional -->
          <div class="bg-yellow-50 rounded-lg p-8 border-l-4 border-yellow-500">
            <h3 class="text-xl font-bold text-gray-900 mb-6 flex items-center">
              <Icon name="heroicons:star" class="w-6 h-6 text-yellow-700 mr-3" />
              Additional SDVOSB Requirements
            </h3>
            <div class="grid grid-cols-1 md:grid-cols-2 gap-6">
              <div>
                <h4 class="font-semibold text-gray-900 mb-3">Disability Requirements</h4>
                <ul class="space-y-2 text-gray-600 text-sm">
                  <li>• Service-connected disability</li>
                  <li>• VA disability rating (any percentage)</li>
                  <li>• VA award letter required</li>
                  <li>• Disability must be service-connected</li>
                </ul>
              </div>
              <div>
                <h4 class="font-semibold text-gray-900 mb-3">Documentation</h4>
                <ul class="space-y-2 text-gray-600 text-sm">
                  <li>• VA disability award letter</li>
                  <li>• Medical evidence if required</li>
                  <li>• Disability rating documentation</li>
                  <li>• Service connection proof</li>
                </ul>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- Certification Options -->
    <section class="py-16 bg-gray-50">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            VOSB Certification Options
          </h2>
          <p class="text-lg text-gray-600">
            Choose the right certification path for your business
          </p>
        </div>

        <div class="grid grid-cols-1 md:grid-cols-2 gap-8">
          <!-- SBA Self-Certification -->
          <div class="bg-white rounded-lg p-8 shadow-sm">
            <div class="flex items-center mb-6">
              <Icon name="heroicons:document-check" class="w-8 h-8 text-green-600 mr-3" />
              <h3 class="text-xl font-bold text-gray-900">SBA Self-Certification</h3>
            </div>
            <div class="mb-6">
              <span class="bg-green-100 text-green-800 px-3 py-1 rounded-full text-sm font-medium">Free</span>
            </div>
            <ul class="space-y-3 text-gray-600 mb-6">
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-1" />
                <span>No certification fees</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-1" />
                <span>Quick application process</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-1" />
                <span>Direct submission to SAM.gov</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:x-mark" class="w-4 h-4 text-red-600 mr-2 mt-1" />
                <span>No access to VA contracts</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:x-mark" class="w-4 h-4 text-red-600 mr-2 mt-1" />
                <span>Subject to eligibility protests</span>
              </li>
            </ul>
            <p class="text-sm text-gray-600">
              Best for: Non-VA federal contracting opportunities
            </p>
          </div>

          <!-- VA Verification -->
          <div class="bg-white rounded-lg p-8 shadow-sm border-l-4 border-blue-500">
            <div class="flex items-center mb-6">
              <Icon name="heroicons:shield-check" class="w-8 h-8 text-blue-600 mr-3" />
              <h3 class="text-xl font-bold text-gray-900">VA Verification</h3>
            </div>
            <div class="mb-6">
              <span class="bg-blue-100 text-blue-800 px-3 py-1 rounded-full text-sm font-medium">Free + Required for VA</span>
            </div>
            <ul class="space-y-3 text-gray-600 mb-6">
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-1" />
                <span>Access to VA contracts</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-1" />
                <span>No certification fees</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-1" />
                <span>Higher credibility</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:x-mark" class="w-4 h-4 text-red-600 mr-2 mt-1" />
                <span>More extensive application</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:x-mark" class="w-4 h-4 text-red-600 mr-2 mt-1" />
                <span>Longer review process</span>
              </li>
            </ul>
            <p class="text-sm text-gray-600">
              Best for: Businesses wanting VA contracting opportunities
            </p>
          </div>
        </div>
      </div>
    </section>

    <!-- Required Documents -->
    <section class="py-16 bg-white">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Required Documentation
          </h2>
          <p class="text-lg text-gray-600">
            Essential documents for VOSB/SDVOSB certification
          </p>
        </div>

        <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-8">
          <!-- Military Documents -->
          <div class="bg-gray-50 rounded-lg p-6">
            <div class="flex items-center justify-center w-12 h-12 bg-blue-100 rounded-lg mb-4">
              <Icon name="heroicons:shield-check" class="w-6 h-6 text-blue-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Military Documents</h3>
            <ul class="text-sm text-gray-600 space-y-2">
              <li>• DD-214 (Certificate of Release)</li>
              <li>• VA disability award letter (SDVOSB)</li>
              <li>• Military service records</li>
              <li>• National Guard/Reserve records</li>
              <li>• Officer service record (if applicable)</li>
            </ul>
          </div>

          <!-- Business Documents -->
          <div class="bg-gray-50 rounded-lg p-6">
            <div class="flex items-center justify-center w-12 h-12 bg-green-100 rounded-lg mb-4">
              <Icon name="heroicons:building-office" class="w-6 h-6 text-green-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Business Documents</h3>
            <ul class="text-sm text-gray-600 space-y-2">
              <li>• Articles of incorporation/organization</li>
              <li>• Corporate bylaws/operating agreement</li>
              <li>• Stock certificates</li>
              <li>• Business tax returns (3 years)</li>
              <li>• Financial statements</li>
            </ul>
          </div>

          <!-- Personal Documents -->
          <div class="bg-gray-50 rounded-lg p-6">
            <div class="flex items-center justify-center w-12 h-12 bg-purple-100 rounded-lg mb-4">
              <Icon name="heroicons:identification" class="w-6 h-6 text-purple-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Personal Documents</h3>
            <ul class="text-sm text-gray-600 space-y-2">
              <li>• Driver's license or passport</li>
              <li>• Resume of veteran owners</li>
              <li>• Personal financial statement</li>
              <li>• Birth certificate</li>
              <li>• Marriage certificate (if applicable)</li>
            </ul>
          </div>
        </div>
      </div>
    </section>

    <!-- CTA Section -->
    <section class="py-16 bg-blue-700 text-white">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <h2 class="text-3xl font-bold mb-4">
          Ready to Get VOSB Certified?
        </h2>
        <p class="text-xl mb-8 opacity-90">
          Honor your service by maximizing your business opportunities. Get expert guidance on VOSB and SDVOSB certification to access veteran set-aside contracts.
        </p>
        <div class="flex flex-col sm:flex-row justify-center space-y-4 sm:space-y-0 sm:space-x-4">
          <NuxtLink 
            to="/contact"
            class="inline-flex items-center justify-center px-8 py-3 bg-white text-blue-700 rounded-md hover:bg-gray-100 transition-colors font-medium"
          >
            <Icon name="heroicons:calendar-days" class="w-5 h-5 mr-2" />
            Schedule VOSB Consultation
          </NuxtLink>
          <NuxtLink 
            to="/resources/certifications"
            class="inline-flex items-center justify-center px-8 py-3 border border-white text-white rounded-md hover:bg-blue-600 transition-colors font-medium"
          >
            <Icon name="heroicons:arrow-left" class="w-5 h-5 mr-2" />
            All Certifications
          </NuxtLink>
        </div>
      </div>
    </section>
  </div>
</template>

<script setup>
// Set page meta for SEO
definePageMeta({
  title: 'VOSB Certification Guide - True North Federal Solutions',
  description: 'Complete guide to Veteran-Owned Small Business (VOSB) and Service-Disabled Veteran-Owned Small Business (SDVOSB) certification programs.'
})

// Set head for SEO
useHead({
  title: 'VOSB & SDVOSB Certification Guide - True North Federal Solutions',
  meta: [
    { 
      name: 'description', 
      content: 'Expert guide to VOSB and SDVOSB certification. Learn requirements, VA verification process, and strategies for veteran-owned business success.' 
    },
    { 
      name: 'keywords', 
      content: 'VOSB certification, SDVOSB certification, veteran owned small business, service disabled veteran, VA verification, military contractors' 
    }
  ]
})
</script>