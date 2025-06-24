<template>
  <div>
    <NavSection />
    
    <!-- 8(a) Header -->
    <section class="bg-green-50 py-16">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <Icon name="heroicons:academic-cap" class="w-16 h-16 text-green-700 mx-auto mb-6" />
        <h1 class="text-4xl font-bold text-gray-900 mb-4">
          8(a) Business Development Program Guide
        </h1>
        <p class="text-xl text-gray-600 max-w-2xl mx-auto">
          Complete guide to the SBA 8(a) Business Development Program for socially and economically disadvantaged business owners seeking federal contracting opportunities.
        </p>
      </div>
    </section>

    <!-- 8(a) Overview -->
    <section class="py-16 bg-white">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="prose prose-lg max-w-none">
          <h2 class="text-2xl font-bold text-gray-900 mb-6">
            What is the 8(a) Business Development Program?
          </h2>
          <p class="text-gray-600 mb-8">
            The 8(a) Business Development Program is a 9-year business assistance program for small disadvantaged businesses. Created by the Small Business Administration (SBA), it provides participants with training, technical assistance, mentoring, and contracting opportunities to help their businesses compete in the federal marketplace.
          </p>

          <div class="grid grid-cols-1 md:grid-cols-2 gap-8 mb-12">
            <!-- Key Benefits -->
            <div>
              <h3 class="text-xl font-semibold text-gray-900 mb-4">Program Benefits</h3>
              <ul class="space-y-3 text-gray-600">
                <li class="flex items-start">
                  <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mr-3 mt-0.5" />
                  <span>8(a) sole source contracts up to $4.5M</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mr-3 mt-0.5" />
                  <span>8(a) set-aside contract competitions</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mr-3 mt-0.5" />
                  <span>Business development assistance</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mr-3 mt-0.5" />
                  <span>Mentoring and training programs</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mr-3 mt-0.5" />
                  <span>SBA business counseling</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mr-3 mt-0.5" />
                  <span>Access to capital and bonding</span>
                </li>
              </ul>
            </div>

            <!-- Program Facts -->
            <div>
              <h3 class="text-xl font-semibold text-gray-900 mb-4">Program Facts</h3>
              <ul class="space-y-3 text-gray-600">
                <li class="flex items-start">
                  <Icon name="heroicons:information-circle" class="w-5 h-5 text-blue-600 mr-3 mt-0.5" />
                  <span>9-year maximum participation</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:information-circle" class="w-5 h-5 text-blue-600 mr-3 mt-0.5" />
                  <span>Annual reviews and business plans</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:information-circle" class="w-5 h-5 text-blue-600 mr-3 mt-0.5" />
                  <span>Federal goal: 5% of contracts</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:information-circle" class="w-5 h-5 text-blue-600 mr-3 mt-0.5" />
                  <span>SBA approval required for participation</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:information-circle" class="w-5 h-5 text-blue-600 mr-3 mt-0.5" />
                  <span>Ongoing compliance requirements</span>
                </li>
                <li class="flex items-start">
                  <Icon name="heroicons:information-circle" class="w-5 h-5 text-blue-600 mr-3 mt-0.5" />
                  <span>Graduation requirements at end</span>
                </li>
              </ul>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- Eligibility Requirements -->
    <section class="py-16 bg-gray-50">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            8(a) Eligibility Requirements
          </h2>
          <p class="text-lg text-gray-600">
            All criteria must be met to qualify for the 8(a) Program
          </p>
        </div>

        <div class="grid grid-cols-1 md:grid-cols-2 gap-8">
          <!-- Social Disadvantage -->
          <div class="bg-white rounded-lg p-8 shadow-sm">
            <h3 class="text-xl font-bold text-gray-900 mb-6 flex items-center">
              <Icon name="heroicons:users" class="w-6 h-6 text-green-700 mr-3" />
              Social Disadvantage
            </h3>
            <div class="space-y-4">
              <div>
                <h4 class="font-semibold text-gray-900 mb-2">Presumptively Socially Disadvantaged Groups</h4>
                <ul class="text-sm text-gray-600 space-y-1">
                  <li>• Black Americans</li>
                  <li>• Hispanic Americans</li>
                  <li>• Native Americans</li>
                  <li>• Asian Pacific Americans</li>
                  <li>• Subcontinent Asian Americans</li>
                </ul>
              </div>
              <div>
                <h4 class="font-semibold text-gray-900 mb-2">Individual Determination</h4>
                <p class="text-sm text-gray-600">
                  Others may qualify by demonstrating social disadvantage through bias, discrimination, or exclusion in American society.
                </p>
              </div>
            </div>
          </div>

          <!-- Economic Disadvantage -->
          <div class="bg-white rounded-lg p-8 shadow-sm">
            <h3 class="text-xl font-bold text-gray-900 mb-6 flex items-center">
              <Icon name="heroicons:currency-dollar" class="w-6 h-6 text-green-700 mr-3" />
              Economic Disadvantage
            </h3>
            <div class="space-y-4">
              <div>
                <h4 class="font-semibold text-gray-900 mb-2">Net Worth Limits (2024)</h4>
                <ul class="text-sm text-gray-600 space-y-1">
                  <li>• Initial: $750,000 (excluding primary residence and business equity)</li>
                  <li>• Continuing: $750,000</li>
                  <li>• Assets include investments, real estate, retirement accounts</li>
                </ul>
              </div>
              <div>
                <h4 class="font-semibold text-gray-900 mb-2">Income Limits</h4>
                <ul class="text-sm text-gray-600 space-y-1">
                  <li>• 2-year average AGI: $400,000</li>
                  <li>• 3-year average AGI: $320,000</li>
                  <li>• Based on personal tax returns</li>
                </ul>
              </div>
            </div>
          </div>

          <!-- Business Requirements -->
          <div class="bg-white rounded-lg p-8 shadow-sm">
            <h3 class="text-xl font-bold text-gray-900 mb-6 flex items-center">
              <Icon name="heroicons:building-office" class="w-6 h-6 text-green-700 mr-3" />
              Business Requirements
            </h3>
            <ul class="space-y-3 text-gray-600 text-sm">
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>51% owned and controlled by disadvantaged individuals</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>Meet SBA size standards for primary NAICS</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>Good character and credit record</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>Business potential for success</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>2+ years in business (generally)</span>
              </li>
            </ul>
          </div>

          <!-- Additional Criteria -->
          <div class="bg-white rounded-lg p-8 shadow-sm">
            <h3 class="text-xl font-bold text-gray-900 mb-6 flex items-center">
              <Icon name="heroicons:document-check" class="w-6 h-6 text-green-700 mr-3" />
              Additional Criteria
            </h3>
            <ul class="space-y-3 text-gray-600 text-sm">
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>U.S. citizenship of disadvantaged owners</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>Active involvement in day-to-day operations</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>No previous 8(a) participation</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>No issues that would preclude certification</span>
              </li>
              <li class="flex items-start">
                <Icon name="heroicons:check" class="w-4 h-4 text-green-600 mr-2 mt-0.5" />
                <span>Demonstrate potential for success</span>
              </li>
            </ul>
          </div>
        </div>
      </div>
    </section>

    <!-- Program Phases -->
    <section class="py-16 bg-white">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            8(a) Program Phases
          </h2>
          <p class="text-lg text-gray-600">
            The 9-year program is divided into two distinct phases
          </p>
        </div>

        <div class="grid grid-cols-1 md:grid-cols-2 gap-8">
          <!-- Developmental Stage -->
          <div class="bg-green-50 rounded-lg p-8">
            <div class="flex items-center mb-6">
              <div class="flex items-center justify-center w-12 h-12 bg-green-100 rounded-lg mr-4">
                <span class="text-green-700 font-bold text-lg">1</span>
              </div>
              <div>
                <h3 class="text-xl font-bold text-gray-900">Developmental Stage</h3>
                <p class="text-gray-600 text-sm">Years 1-4</p>
              </div>
            </div>
            <div class="space-y-4">
              <div>
                <h4 class="font-semibold text-gray-900 mb-2">Focus Areas</h4>
                <ul class="text-sm text-gray-600 space-y-1">
                  <li>• Building business competencies</li>
                  <li>• Accessing set-aside and sole source contracts</li>
                  <li>• Receiving business development assistance</li>
                  <li>• Participating in training programs</li>
                </ul>
              </div>
              <div>
                <h4 class="font-semibold text-gray-900 mb-2">Benefits Available</h4>
                <ul class="text-sm text-gray-600 space-y-1">
                  <li>• 8(a) set-aside contracts</li>
                  <li>• 8(a) sole source up to $4.5M</li>
                  <li>• Business counseling and training</li>
                  <li>• Mentoring opportunities</li>
                </ul>
              </div>
            </div>
          </div>

          <!-- Transitional Stage -->
          <div class="bg-blue-50 rounded-lg p-8">
            <div class="flex items-center mb-6">
              <div class="flex items-center justify-center w-12 h-12 bg-blue-100 rounded-lg mr-4">
                <span class="text-blue-700 font-bold text-lg">2</span>
              </div>
              <div>
                <h3 class="text-xl font-bold text-gray-900">Transitional Stage</h3>
                <p class="text-gray-600 text-sm">Years 5-9</p>
              </div>
            </div>
            <div class="space-y-4">
              <div>
                <h4 class="font-semibold text-gray-900 mb-2">Focus Areas</h4>
                <ul class="text-sm text-gray-600 space-y-1">
                  <li>• Preparing for graduation</li>
                  <li>• Competing in unrestricted marketplace</li>
                  <li>• Reducing dependence on 8(a) contracts</li>
                  <li>• Building competitive capabilities</li>
                </ul>
              </div>
              <div>
                <h4 class="font-semibold text-gray-900 mb-2">Requirements</h4>
                <ul class="text-sm text-gray-600 space-y-1">
                  <li>• Annual business plans</li>
                  <li>• Graduation planning</li>
                  <li>• Competitive mix targets</li>
                  <li>• Performance milestones</li>
                </ul>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- Application Process -->
    <section class="py-16 bg-gray-50">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            8(a) Application Process
          </h2>
          <p class="text-lg text-gray-600">
            Step-by-step guide to applying for the 8(a) Program
          </p>
        </div>

        <div class="grid grid-cols-1 md:grid-cols-4 gap-8">
          <!-- Step 1 -->
          <div class="text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-green-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
              1
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Eligibility Review</h3>
            <p class="text-gray-600 text-sm">
              Conduct thorough review of social, economic, and business eligibility requirements.
            </p>
          </div>

          <!-- Step 2 -->
          <div class="text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-green-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
              2
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Document Preparation</h3>
            <p class="text-gray-600 text-sm">
              Gather extensive documentation including financial records, personal history, and business information.
            </p>
          </div>

          <!-- Step 3 -->
          <div class="text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-green-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
              3
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">SBA Application</h3>
            <p class="text-gray-600 text-sm">
              Submit comprehensive application through SBA's online portal with all supporting documentation.
            </p>
          </div>

          <!-- Step 4 -->
          <div class="text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-green-700 text-white rounded-full mx-auto mb-4 text-xl font-bold">
              4
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Review & Approval</h3>
            <p class="text-gray-600 text-sm">
              SBA conducts detailed review (90+ days) and makes determination on program admission.
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
            Comprehensive documentation required for 8(a) application
          </p>
        </div>

        <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-8">
          <!-- Personal Documents -->
          <div class="bg-gray-50 rounded-lg p-6">
            <div class="flex items-center justify-center w-12 h-12 bg-green-100 rounded-lg mb-4">
              <Icon name="heroicons:identification" class="w-6 h-6 text-green-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Personal Documents</h3>
            <ul class="text-sm text-gray-600 space-y-2">
              <li>• Birth certificate or passport</li>
              <li>• Personal tax returns (3 years)</li>
              <li>• Personal financial statement</li>
              <li>• Resume and education records</li>
              <li>• Character references</li>
              <li>• Social disadvantage narrative</li>
            </ul>
          </div>

          <!-- Business Documents -->
          <div class="bg-gray-50 rounded-lg p-6">
            <div class="flex items-center justify-center w-12 h-12 bg-blue-100 rounded-lg mb-4">
              <Icon name="heroicons:building-office" class="w-6 h-6 text-blue-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Business Documents</h3>
            <ul class="text-sm text-gray-600 space-y-2">
              <li>• Articles of incorporation/organization</li>
              <li>• Corporate bylaws/operating agreement</li>
              <li>• Stock certificates/membership interests</li>
              <li>• Business tax returns (3 years)</li>
              <li>• Financial statements</li>
              <li>• Business plan</li>
            </ul>
          </div>

          <!-- Financial Documents -->
          <div class="bg-gray-50 rounded-lg p-6">
            <div class="flex items-center justify-center w-12 h-12 bg-purple-100 rounded-lg mb-4">
              <Icon name="heroicons:currency-dollar" class="w-6 h-6 text-purple-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Financial Documents</h3>
            <ul class="text-sm text-gray-600 space-y-2">
              <li>• Bank statements (business and personal)</li>
              <li>• Investment account statements</li>
              <li>• Real estate appraisals</li>
              <li>• Loan agreements and notes</li>
              <li>• Asset valuations</li>
              <li>• Retirement account statements</li>
            </ul>
          </div>
        </div>
      </div>
    </section>

    <!-- Common Challenges -->
    <section class="py-16 bg-gray-50">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Common 8(a) Application Challenges
          </h2>
          <p class="text-lg text-gray-600">
            Understanding typical issues that can delay or prevent approval
          </p>
        </div>

        <div class="grid grid-cols-1 md:grid-cols-2 gap-8">
          <!-- Challenge 1 -->
          <div class="bg-white rounded-lg p-6 border-l-4 border-red-500">
            <div class="flex items-start space-x-4">
              <Icon name="heroicons:exclamation-triangle" class="w-6 h-6 text-red-500 mt-1" />
              <div>
                <h3 class="text-lg font-semibold text-gray-900 mb-2">Economic Disadvantage Documentation</h3>
                <p class="text-gray-600 text-sm">
                  Failure to properly document net worth limits or income requirements. Complex asset calculations and valuations often cause delays.
                </p>
              </div>
            </div>
          </div>

          <!-- Challenge 2 -->
          <div class="bg-white rounded-lg p-6 border-l-4 border-red-500">
            <div class="flex items-start space-x-4">
              <Icon name="heroicons:exclamation-triangle" class="w-6 h-6 text-red-500 mt-1" />
              <div>
                <h3 class="text-lg font-semibold text-gray-900 mb-2">Social Disadvantage Narrative</h3>
                <p class="text-gray-600 text-sm">
                  Inadequate documentation of social disadvantage experiences or failure to establish how bias affected business opportunities.
                </p>
              </div>
            </div>
          </div>

          <!-- Challenge 3 -->
          <div class="bg-white rounded-lg p-6 border-l-4 border-yellow-500">
            <div class="flex items-start space-x-4">
              <Icon name="heroicons:exclamation-triangle" class="w-6 h-6 text-yellow-500 mt-1" />
              <div>
                <h3 class="text-lg font-semibold text-gray-900 mb-2">Control Issues</h3>
                <p class="text-gray-600 text-sm">
                  Complex ownership structures or inadequate demonstration of management control by disadvantaged individuals.
                </p>
              </div>
            </div>
          </div>

          <!-- Challenge 4 -->
          <div class="bg-white rounded-lg p-6 border-l-4 border-yellow-500">
            <div class="flex items-start space-x-4">
              <Icon name="heroicons:exclamation-triangle" class="w-6 h-6 text-yellow-500 mt-1" />
              <div>
                <h3 class="text-lg font-semibold text-gray-900 mb-2">Business Potential</h3>
                <p class="text-gray-600 text-sm">
                  Insufficient demonstration of business potential for success or lack of competitive positioning in the marketplace.
                </p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- CTA Section -->
    <section class="py-16 bg-green-700 text-white">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <h2 class="text-3xl font-bold mb-4">
          Ready to Apply for the 8(a) Program?
        </h2>
        <p class="text-xl mb-8 opacity-90">
          The 8(a) application is complex and requires extensive documentation. Get expert guidance to ensure your application is complete, accurate, and compelling.
        </p>
        <div class="flex flex-col sm:flex-row justify-center space-y-4 sm:space-y-0 sm:space-x-4">
          <NuxtLink 
            to="/contact"
            class="inline-flex items-center justify-center px-8 py-3 bg-white text-green-700 rounded-md hover:bg-gray-100 transition-colors font-medium"
          >
            <Icon name="heroicons:calendar-days" class="w-5 h-5 mr-2" />
            Schedule 8(a) Consultation
          </NuxtLink>
          <NuxtLink 
            to="/resources/certifications"
            class="inline-flex items-center justify-center px-8 py-3 border border-white text-white rounded-md hover:bg-green-600 transition-colors font-medium"
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
  title: '8(a) Business Development Program Guide - True North Federal Solutions',
  description: 'Complete guide to the SBA 8(a) Business Development Program for socially and economically disadvantaged businesses seeking federal contracts.'
})

// Set head for SEO
useHead({
  title: '8(a) Business Development Program Guide - True North Federal Solutions',
  meta: [
    { 
      name: 'description', 
      content: 'Expert guide to SBA 8(a) certification. Learn social and economic disadvantage requirements, application process, and program benefits.' 
    },
    { 
      name: 'keywords', 
      content: '8a certification, SBA 8a program, socially disadvantaged business, economically disadvantaged, minority business enterprise, small business development' 
    }
  ]
})
</script>