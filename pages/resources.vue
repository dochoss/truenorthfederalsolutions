<template>
  <div>
    <NavSection />
    
    <!-- Resources Header -->
    <section class="bg-blue-50 py-16">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <Icon name="heroicons:book-open" class="w-16 h-16 text-blue-700 mx-auto mb-6" />
        <h1 class="text-4xl font-bold text-gray-900 mb-4">
          Federal Contracting Resources
        </h1>
        <p class="text-xl text-gray-600 max-w-2xl mx-auto">
          Access comprehensive guides, templates, and educational content to help you navigate the federal contracting landscape with confidence.
        </p>
      </div>
    </section>

    <!-- Resource Categories -->
    <section class="py-16 bg-white">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="grid grid-cols-1 md:grid-cols-3 gap-8 mb-12">
          <!-- Blog & Articles -->
          <div class="bg-gray-50 rounded-lg p-8 hover:shadow-lg transition-shadow text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-blue-100 rounded-lg mx-auto mb-6">
              <Icon name="heroicons:newspaper" class="w-8 h-8 text-blue-700" />
            </div>
            <h3 class="text-xl font-bold text-gray-900 mb-4">Blog & Articles</h3>
            <p class="text-gray-600 mb-6">
              Stay updated with the latest insights, best practices, and industry news in federal contracting.
            </p>
            <NuxtLink 
              to="/resources/blog"
              class="inline-flex items-center justify-center w-full bg-blue-700 text-white py-3 px-6 rounded-md hover:bg-blue-800 transition-colors font-medium"
            >
              Read Articles
              <Icon name="heroicons:arrow-right" class="w-4 h-4 ml-2" />
            </NuxtLink>
          </div>

          <!-- Guides & Templates -->
          <div class="bg-gray-50 rounded-lg p-8 hover:shadow-lg transition-shadow text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-green-100 rounded-lg mx-auto mb-6">
              <Icon name="heroicons:document-arrow-down" class="w-8 h-8 text-green-700" />
            </div>
            <h3 class="text-xl font-bold text-gray-900 mb-4">Guides & Templates</h3>
            <p class="text-gray-600 mb-6">
              Download practical guides, checklists, and templates to streamline your federal contracting process.
            </p>
            <NuxtLink 
              to="/resources/guides"
              class="inline-flex items-center justify-center w-full bg-blue-700 text-white py-3 px-6 rounded-md hover:bg-blue-800 transition-colors font-medium"
            >
              Browse Guides
              <Icon name="heroicons:arrow-right" class="w-4 h-4 ml-2" />
            </NuxtLink>
          </div>

          <!-- Certification Help -->
          <div class="bg-gray-50 rounded-lg p-8 hover:shadow-lg transition-shadow text-center">
            <div class="flex items-center justify-center w-16 h-16 bg-purple-100 rounded-lg mx-auto mb-6">
              <Icon name="heroicons:trophy" class="w-8 h-8 text-purple-700" />
            </div>
            <h3 class="text-xl font-bold text-gray-900 mb-4">Certification Help</h3>
            <p class="text-gray-600 mb-6">
              Get guidance on WOSB, VOSB, 8(a), and other certifications to maximize your contracting opportunities.
            </p>
            <NuxtLink 
              to="/resources/certifications"
              class="inline-flex items-center justify-center w-full bg-blue-700 text-white py-3 px-6 rounded-md hover:bg-blue-800 transition-colors font-medium"
            >
              Learn About Certifications
              <Icon name="heroicons:arrow-right" class="w-4 h-4 ml-2" />
            </NuxtLink>
          </div>
        </div>
      </div>
    </section>

    <!-- Featured Content -->
    <section class="py-16 bg-gray-50">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Featured Resources
          </h2>
          <p class="text-lg text-gray-600">
            Popular guides and articles to get you started
          </p>
        </div>

        <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-8">
          <!-- Featured Article 1 -->
          <div class="bg-white rounded-lg p-6 shadow-sm hover:shadow-md transition-shadow">
            <div class="flex items-center justify-center w-12 h-12 bg-blue-100 rounded-lg mb-4">
              <Icon name="heroicons:rocket-launch" class="w-6 h-6 text-blue-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">
              Getting Started with Federal Contracting
            </h3>
            <p class="text-gray-600 text-sm mb-4">
              A comprehensive guide to the first steps every small business should take when entering the federal marketplace.
            </p>
            <div class="flex items-center justify-between">
              <span class="text-xs text-gray-500">Beginner Guide</span>
              <button class="text-blue-700 hover:text-blue-800 text-sm font-medium">
                Coming Soon
              </button>
            </div>
          </div>

          <!-- Featured Article 2 -->
          <div class="bg-white rounded-lg p-6 shadow-sm hover:shadow-md transition-shadow">
            <div class="flex items-center justify-center w-12 h-12 bg-green-100 rounded-lg mb-4">
              <Icon name="heroicons:document-check" class="w-6 h-6 text-green-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">
              SAM Registration Checklist
            </h3>
            <p class="text-gray-600 text-sm mb-4">
              Step-by-step checklist to ensure your SAM.gov registration is complete and accurate for federal contracting.
            </p>
            <div class="flex items-center justify-between">
              <span class="text-xs text-gray-500">Essential Template</span>
              <button class="text-blue-700 hover:text-blue-800 text-sm font-medium">
                Coming Soon
              </button>
            </div>
          </div>

          <!-- Featured Article 3 -->
          <div class="bg-white rounded-lg p-6 shadow-sm hover:shadow-md transition-shadow">
            <div class="flex items-center justify-center w-12 h-12 bg-purple-100 rounded-lg mb-4">
              <Icon name="heroicons:shield-check" class="w-6 h-6 text-purple-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">
              WOSB Certification Guide
            </h3>
            <p class="text-gray-600 text-sm mb-4">
              Complete guide to Woman-Owned Small Business certification, including requirements and application process.
            </p>
            <div class="flex items-center justify-between">
              <span class="text-xs text-gray-500">Certification Guide</span>
              <button class="text-blue-700 hover:text-blue-800 text-sm font-medium">
                Coming Soon
              </button>
            </div>
          </div>

          <!-- Featured Article 4 -->
          <div class="bg-white rounded-lg p-6 shadow-sm hover:shadow-md transition-shadow">
            <div class="flex items-center justify-center w-12 h-12 bg-orange-100 rounded-lg mb-4">
              <Icon name="heroicons:chart-bar" class="w-6 h-6 text-orange-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">
              Proposal Writing Best Practices
            </h3>
            <p class="text-gray-600 text-sm mb-4">
              Learn the key elements of winning federal proposals from a contracting officer's perspective.
            </p>
            <div class="flex items-center justify-between">
              <span class="text-xs text-gray-500">Expert Insights</span>
              <button class="text-blue-700 hover:text-blue-800 text-sm font-medium">
                Coming Soon
              </button>
            </div>
          </div>

          <!-- Featured Article 5 -->
          <div class="bg-white rounded-lg p-6 shadow-sm hover:shadow-md transition-shadow">
            <div class="flex items-center justify-center w-12 h-12 bg-red-100 rounded-lg mb-4">
              <Icon name="heroicons:exclamation-triangle" class="w-6 h-6 text-red-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">
              Common FAR Compliance Mistakes
            </h3>
            <p class="text-gray-600 text-sm mb-4">
              Avoid costly mistakes by understanding the most common FAR compliance issues and how to prevent them.
            </p>
            <div class="flex items-center justify-between">
              <span class="text-xs text-gray-500">Compliance Guide</span>
              <button class="text-blue-700 hover:text-blue-800 text-sm font-medium">
                Coming Soon
              </button>
            </div>
          </div>

          <!-- Featured Article 6 -->
          <div class="bg-white rounded-lg p-6 shadow-sm hover:shadow-md transition-shadow">
            <div class="flex items-center justify-center w-12 h-12 bg-indigo-100 rounded-lg mb-4">
              <Icon name="heroicons:calculator" class="w-6 h-6 text-indigo-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-3">
              Bid/No-Bid Decision Framework
            </h3>
            <p class="text-gray-600 text-sm mb-4">
              Strategic framework to help you make informed decisions about which opportunities to pursue.
            </p>
            <div class="flex items-center justify-between">
              <span class="text-xs text-gray-500">Strategy Tool</span>
              <button class="text-blue-700 hover:text-blue-800 text-sm font-medium">
                Coming Soon
              </button>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- Newsletter Signup -->
    <section class="py-16 bg-blue-700 text-white">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <Icon name="heroicons:envelope" class="w-12 h-12 mx-auto mb-6 opacity-80" />
        <h2 class="text-3xl font-bold mb-4">
          Stay Updated with Federal Contracting Insights
        </h2>
        <p class="text-xl mb-8 opacity-90">
          Get the latest tips, guides, and industry updates delivered directly to your inbox.
        </p>
        <form class="max-w-md mx-auto flex space-x-4">
          <input
            type="email"
            placeholder="Enter your email address"
            class="flex-1 px-4 py-3 rounded-md text-gray-900 focus:outline-none focus:ring-2 focus:ring-blue-300"
          />
          <button
            type="submit"
            class="bg-white text-blue-700 px-6 py-3 rounded-md hover:bg-gray-100 transition-colors font-medium"
          >
            Subscribe
          </button>
        </form>
        <p class="text-sm mt-4 opacity-80">
          No spam, unsubscribe at any time.
        </p>
      </div>
    </section>

    <!-- Tools Preview (Phase 2) -->
    <section class="py-16 bg-gray-50">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <div class="bg-white rounded-lg p-8 shadow-sm">
          <Icon name="heroicons:cog-6-tooth" class="w-16 h-16 text-gray-400 mx-auto mb-6" />
          <h2 class="text-2xl font-bold text-gray-900 mb-4">
            AI-Powered Tools Coming Soon
          </h2>
          <p class="text-lg text-gray-600 mb-6">
            We're developing intelligent assessment tools to help you make better decisions about federal contracting opportunities.
          </p>
          <div class="grid grid-cols-1 md:grid-cols-2 gap-6 text-left">
            <div class="flex items-start space-x-3">
              <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mt-1" />
              <div>
                <h3 class="font-semibold text-gray-900">Business Readiness Assessment</h3>
                <p class="text-sm text-gray-600">Evaluate your readiness for federal contracting</p>
              </div>
            </div>
            <div class="flex items-start space-x-3">
              <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mt-1" />
              <div>
                <h3 class="font-semibold text-gray-900">Bid/No-Bid Decision Tool</h3>
                <p class="text-sm text-gray-600">Get recommendations on which opportunities to pursue</p>
              </div>
            </div>
          </div>
          <div class="mt-8">
            <NuxtLink 
              to="/contact"
              class="inline-flex items-center bg-blue-700 text-white px-6 py-3 rounded-md hover:bg-blue-800 transition-colors font-medium"
            >
              <Icon name="heroicons:bell" class="w-5 h-5 mr-2" />
              Get Notified When Available
            </NuxtLink>
          </div>
        </div>
      </div>
    </section>
  </div>
</template>

<script setup>
// Set page meta for SEO
definePageMeta({
  title: 'Resources - True North Federal Solutions',
  description: 'Access comprehensive federal contracting resources including guides, templates, articles, and certification help for small businesses.'
})

// Set head for SEO
useHead({
  title: 'Federal Contracting Resources - True North Federal Solutions',
  meta: [
    { 
      name: 'description', 
      content: 'Free federal contracting resources for small businesses. Access guides, templates, articles, and certification help to succeed in government contracting.' 
    },
    { 
      name: 'keywords', 
      content: 'federal contracting resources, small business guides, government contract templates, WOSB certification, VOSB certification, 8a program' 
    }
  ]
})
</script>