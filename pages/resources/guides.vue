<template>
  <div>
    <NavSection />
    
    <!-- Guides Header -->
    <section class="bg-green-50 py-16">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <Icon name="heroicons:document-arrow-down" class="w-16 h-16 text-green-700 mx-auto mb-6" />
        <h1 class="text-4xl font-bold text-gray-900 mb-4">
          Federal Contracting Guides & Templates
        </h1>
        <p class="text-xl text-gray-600 max-w-2xl mx-auto">
          Download practical guides, checklists, and templates to streamline your federal contracting process and ensure compliance.
        </p>
      </div>
    </section>

    <!-- Featured Guide -->
    <section class="py-16 bg-white">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Featured Guide
          </h2>
        </div>

        <div class="bg-gradient-to-r from-green-600 to-green-700 rounded-lg overflow-hidden shadow-xl">
          <div class="px-8 py-12 text-white">
            <div class="max-w-3xl">
              <div class="flex items-center space-x-2 mb-4">
                <span class="bg-green-500 text-white px-3 py-1 rounded-full text-sm font-medium">Featured</span>
                <span class="text-green-200 text-sm">Coming Soon</span>
              </div>
              <h3 class="text-2xl md:text-3xl font-bold mb-4">
                Complete Federal Contracting Setup Checklist
              </h3>
              <p class="text-green-100 text-lg mb-6">
                Comprehensive 50-point checklist covering everything from business formation to contract readiness. Ensure you don't miss any critical steps.
              </p>
              <div class="flex flex-wrap items-center space-x-6 text-sm text-green-200">
                <span>• PDF Download</span>
                <span>• Interactive Checklist</span>
                <span>• Step-by-Step Instructions</span>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- Guide Categories -->
    <section class="py-16 bg-gray-50">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Guide Categories
          </h2>
          <p class="text-lg text-gray-600">
            Find exactly what you need to move forward
          </p>
        </div>

        <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-8">
          <!-- Setup Guides -->
          <div class="bg-white rounded-lg p-6 shadow-sm hover:shadow-md transition-shadow">
            <div class="flex items-center justify-center w-12 h-12 bg-blue-100 rounded-lg mb-4">
              <Icon name="heroicons:cog-6-tooth" class="w-6 h-6 text-blue-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Setup & Registration</h3>
            <p class="text-gray-600 text-sm mb-4">
              Step-by-step guides for business setup, registrations, and getting contract-ready
            </p>
            <ul class="text-xs text-gray-600 space-y-1 mb-4">
              <li>• SAM.gov Registration Guide</li>
              <li>• CAGE Code Application</li>
              <li>• Business Formation Checklist</li>
              <li>• Banking Setup Requirements</li>
            </ul>
            <div class="text-green-700 text-sm font-medium">6 guides coming soon</div>
          </div>

          <!-- Proposal Templates -->
          <div class="bg-white rounded-lg p-6 shadow-sm hover:shadow-md transition-shadow">
            <div class="flex items-center justify-center w-12 h-12 bg-green-100 rounded-lg mb-4">
              <Icon name="heroicons:document-text" class="w-6 h-6 text-green-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Proposal Templates</h3>
            <p class="text-gray-600 text-sm mb-4">
              Professional templates and frameworks for developing winning proposals
            </p>
            <ul class="text-xs text-gray-600 space-y-1 mb-4">
              <li>• Technical Proposal Template</li>
              <li>• Past Performance Framework</li>
              <li>• Compliance Matrix Template</li>
              <li>• Price Volume Structure</li>
            </ul>
            <div class="text-green-700 text-sm font-medium">8 templates coming soon</div>
          </div>

          <!-- Compliance Checklists -->
          <div class="bg-white rounded-lg p-6 shadow-sm hover:shadow-md transition-shadow">
            <div class="flex items-center justify-center w-12 h-12 bg-orange-100 rounded-lg mb-4">
              <Icon name="heroicons:check-badge" class="w-6 h-6 text-orange-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Compliance Checklists</h3>
            <p class="text-gray-600 text-sm mb-4">
              Ensure you meet all FAR requirements with comprehensive compliance checklists
            </p>
            <ul class="text-xs text-gray-600 space-y-1 mb-4">
              <li>• FAR Compliance Checklist</li>
              <li>• SCA Requirements</li>
              <li>• Davis-Bacon Compliance</li>
              <li>• Buy American Verification</li>
            </ul>
            <div class="text-green-700 text-sm font-medium">10 checklists coming soon</div>
          </div>

          <!-- Contract Management -->
          <div class="bg-white rounded-lg p-6 shadow-sm hover:shadow-md transition-shadow">
            <div class="flex items-center justify-center w-12 h-12 bg-purple-100 rounded-lg mb-4">
              <Icon name="heroicons:clipboard-document-list" class="w-6 h-6 text-purple-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Contract Management</h3>
            <p class="text-gray-600 text-sm mb-4">
              Tools and templates for managing federal contracts throughout their lifecycle
            </p>
            <ul class="text-xs text-gray-600 space-y-1 mb-4">
              <li>• Project Management Templates</li>
              <li>• Invoice Templates</li>
              <li>• Performance Tracking</li>
              <li>• Change Management</li>
            </ul>
            <div class="text-green-700 text-sm font-medium">5 templates coming soon</div>
          </div>

          <!-- Financial Tools -->
          <div class="bg-white rounded-lg p-6 shadow-sm hover:shadow-md transition-shadow">
            <div class="flex items-center justify-center w-12 h-12 bg-red-100 rounded-lg mb-4">
              <Icon name="heroicons:calculator" class="w-6 h-6 text-red-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Financial Tools</h3>
            <p class="text-gray-600 text-sm mb-4">
              Spreadsheets and calculators for pricing, cost analysis, and financial planning
            </p>
            <ul class="text-xs text-gray-600 space-y-1 mb-4">
              <li>• Pricing Calculator</li>
              <li>• Cost Analysis Template</li>
              <li>• ROI Calculator</li>
              <li>• Budget Planning Tool</li>
            </ul>
            <div class="text-green-700 text-sm font-medium">4 tools coming soon</div>
          </div>

          <!-- Legal Documents -->
          <div class="bg-white rounded-lg p-6 shadow-sm hover:shadow-md transition-shadow">
            <div class="flex items-center justify-center w-12 h-12 bg-indigo-100 rounded-lg mb-4">
              <Icon name="heroicons:scale" class="w-6 h-6 text-indigo-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">Legal Templates</h3>
            <p class="text-gray-600 text-sm mb-4">
              Legal document templates and frameworks for federal contracting requirements
            </p>
            <ul class="text-xs text-gray-600 space-y-1 mb-4">
              <li>• Subcontractor Agreements</li>
              <li>• NDA Templates</li>
              <li>• Teaming Agreements</li>
              <li>• Employment Contracts</li>
            </ul>
            <div class="text-green-700 text-sm font-medium">7 templates coming soon</div>
          </div>
        </div>
      </div>
    </section>

    <!-- Popular Downloads -->
    <section class="py-16 bg-white">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Most Popular Downloads
          </h2>
          <p class="text-lg text-gray-600">
            Essential resources every federal contractor needs
          </p>
        </div>

        <div class="grid grid-cols-1 md:grid-cols-2 gap-8">
          <!-- Download 1 -->
          <div class="bg-gray-50 rounded-lg p-6 border-l-4 border-green-500">
            <div class="flex items-start space-x-4">
              <div class="flex items-center justify-center w-12 h-12 bg-green-100 rounded-lg">
                <Icon name="heroicons:document-check" class="w-6 h-6 text-green-700" />
              </div>
              <div class="flex-1">
                <div class="flex items-center space-x-2 mb-2">
                  <h3 class="text-lg font-semibold text-gray-900">SAM.gov Registration Checklist</h3>
                  <span class="bg-green-100 text-green-800 px-2 py-1 rounded text-xs font-medium">Free</span>
                </div>
                <p class="text-gray-600 text-sm mb-3">
                  Complete checklist to ensure your SAM.gov registration is accurate and complete on the first try.
                </p>
                <div class="flex items-center justify-between">
                  <div class="flex items-center space-x-4 text-xs text-gray-500">
                    <span>• PDF Download</span>
                    <span>• 3 pages</span>
                    <span>• Beginner</span>
                  </div>
                  <button class="text-green-700 hover:text-green-800 text-sm font-medium">
                    Coming Soon
                  </button>
                </div>
              </div>
            </div>
          </div>

          <!-- Download 2 -->
          <div class="bg-gray-50 rounded-lg p-6 border-l-4 border-blue-500">
            <div class="flex items-start space-x-4">
              <div class="flex items-center justify-center w-12 h-12 bg-blue-100 rounded-lg">
                <Icon name="heroicons:chart-bar" class="w-6 h-6 text-blue-700" />
              </div>
              <div class="flex-1">
                <div class="flex items-center space-x-2 mb-2">
                  <h3 class="text-lg font-semibold text-gray-900">NAICS Code Selection Guide</h3>
                  <span class="bg-blue-100 text-blue-800 px-2 py-1 rounded text-xs font-medium">Free</span>
                </div>
                <p class="text-gray-600 text-sm mb-3">
                  Strategic approach to choosing NAICS codes that maximize opportunities while maintaining competitive advantages.
                </p>
                <div class="flex items-center justify-between">
                  <div class="flex items-center space-x-4 text-xs text-gray-500">
                    <span>• PDF Download</span>
                    <span>• 8 pages</span>
                    <span>• Intermediate</span>
                  </div>
                  <button class="text-blue-700 hover:text-blue-800 text-sm font-medium">
                    Coming Soon
                  </button>
                </div>
              </div>
            </div>
          </div>

          <!-- Download 3 -->
          <div class="bg-gray-50 rounded-lg p-6 border-l-4 border-purple-500">
            <div class="flex items-start space-x-4">
              <div class="flex items-center justify-center w-12 h-12 bg-purple-100 rounded-lg">
                <Icon name="heroicons:document-text" class="w-6 h-6 text-purple-700" />
              </div>
              <div class="flex-1">
                <div class="flex items-center space-x-2 mb-2">
                  <h3 class="text-lg font-semibold text-gray-900">Proposal Compliance Matrix Template</h3>
                  <span class="bg-purple-100 text-purple-800 px-2 py-1 rounded text-xs font-medium">Premium</span>
                </div>
                <p class="text-gray-600 text-sm mb-3">
                  Professional template for creating compliance matrices that ensure all RFP requirements are addressed.
                </p>
                <div class="flex items-center justify-between">
                  <div class="flex items-center space-x-4 text-xs text-gray-500">
                    <span>• Excel Template</span>
                    <span>• Instructions</span>
                    <span>• Advanced</span>
                  </div>
                  <button class="text-purple-700 hover:text-purple-800 text-sm font-medium">
                    Coming Soon
                  </button>
                </div>
              </div>
            </div>
          </div>

          <!-- Download 4 -->
          <div class="bg-gray-50 rounded-lg p-6 border-l-4 border-orange-500">
            <div class="flex items-start space-x-4">
              <div class="flex items-center justify-center w-12 h-12 bg-orange-100 rounded-lg">
                <Icon name="heroicons:shield-check" class="w-6 h-6 text-orange-700" />
              </div>
              <div class="flex-1">
                <div class="flex items-center space-x-2 mb-2">
                  <h3 class="text-lg font-semibold text-gray-900">FAR Compliance Quick Reference</h3>
                  <span class="bg-orange-100 text-orange-800 px-2 py-1 rounded text-xs font-medium">Free</span>
                </div>
                <p class="text-gray-600 text-sm mb-3">
                  Essential FAR clauses and requirements every contractor must know, organized by contract type and situation.
                </p>
                <div class="flex items-center justify-between">
                  <div class="flex items-center space-x-4 text-xs text-gray-500">
                    <span>• PDF Reference</span>
                    <span>• 12 pages</span>
                    <span>• All Levels</span>
                  </div>
                  <button class="text-orange-700 hover:text-orange-800 text-sm font-medium">
                    Coming Soon
                  </button>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- Newsletter Signup -->
    <section class="py-16 bg-green-700 text-white">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <Icon name="heroicons:gift" class="w-12 h-12 mx-auto mb-6 opacity-80" />
        <h2 class="text-3xl font-bold mb-4">
          Get New Resources First
        </h2>
        <p class="text-xl mb-8 opacity-90">
          Be the first to access new guides and templates. Plus, get our exclusive "Federal Contracting Quick Start Kit" for free.
        </p>
        <form class="max-w-md mx-auto flex space-x-4">
          <input
            type="email"
            placeholder="Enter your email address"
            class="flex-1 px-4 py-3 rounded-md text-gray-900 focus:outline-none focus:ring-2 focus:ring-green-300"
          />
          <button
            type="submit"
            class="bg-white text-green-700 px-6 py-3 rounded-md hover:bg-gray-100 transition-colors font-medium"
          >
            Get Free Kit
          </button>
        </form>
        <p class="text-sm mt-4 opacity-80">
          Free Quick Start Kit includes: Setup checklist, NAICS guide, and template samples.
        </p>
      </div>
    </section>

    <!-- Browse More -->
    <section class="py-16 bg-gray-50">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <h2 class="text-2xl font-bold text-gray-900 mb-4">
          Need More Help?
        </h2>
        <p class="text-lg text-gray-600 mb-8">
          Explore our other resources or get personalized guidance
        </p>
        <div class="flex flex-col sm:flex-row justify-center space-y-4 sm:space-y-0 sm:space-x-4">
          <NuxtLink 
            to="/resources/blog"
            class="inline-flex items-center justify-center px-6 py-3 bg-green-700 text-white rounded-md hover:bg-green-800 transition-colors font-medium"
          >
            <Icon name="heroicons:newspaper" class="w-5 h-5 mr-2" />
            Read Our Blog
          </NuxtLink>
          <NuxtLink 
            to="/contact"
            class="inline-flex items-center justify-center px-6 py-3 border border-green-700 text-green-700 rounded-md hover:bg-green-50 transition-colors font-medium"
          >
            <Icon name="heroicons:calendar-days" class="w-5 h-5 mr-2" />
            Schedule Consultation
          </NuxtLink>
        </div>
      </div>
    </section>
  </div>
</template>

<script setup>
// Set page meta for SEO
definePageMeta({
  title: 'Guides & Templates - True North Federal Solutions',
  description: 'Download free federal contracting guides, templates, and checklists. SAM registration, proposal templates, compliance checklists, and more.'
})

// Set head for SEO
useHead({
  title: 'Federal Contracting Guides & Templates - True North Federal Solutions',
  meta: [
    { 
      name: 'description', 
      content: 'Free and premium federal contracting guides, templates, and checklists. SAM registration, NAICS codes, proposal templates, compliance tools.' 
    },
    { 
      name: 'keywords', 
      content: 'federal contracting templates, SAM registration guide, proposal templates, compliance checklists, government contracting tools' 
    }
  ]
})
</script>