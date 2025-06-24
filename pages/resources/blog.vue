<template>
  <div>
    <NavSection />
    
    <!-- Blog Header -->
    <section class="bg-blue-50 py-16">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <Icon name="heroicons:newspaper" class="w-16 h-16 text-blue-700 mx-auto mb-6" />
        <h1 class="text-4xl font-bold text-gray-900 mb-4">
          Federal Contracting Blog & Articles
        </h1>
        <p class="text-xl text-gray-600 max-w-2xl mx-auto">
          Stay updated with the latest insights, best practices, and industry news in federal contracting from experienced professionals.
        </p>
      </div>
    </section>

    <!-- Featured Article -->
    <section class="py-16 bg-white">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Featured Article
          </h2>
        </div>

        <div class="bg-gradient-to-r from-blue-600 to-blue-700 rounded-lg overflow-hidden shadow-xl">
          <div class="px-8 py-12 text-white">
            <div class="max-w-3xl">
              <div class="flex items-center space-x-2 mb-4">
                <span class="bg-blue-500 text-white px-3 py-1 rounded-full text-sm font-medium">Featured</span>
                <span class="text-blue-200 text-sm">Coming Soon</span>
              </div>
              <h3 class="text-2xl md:text-3xl font-bold mb-4">
                The Complete Guide to Federal Contracting Success in 2024
              </h3>
              <p class="text-blue-100 text-lg mb-6">
                Everything you need to know to start and grow your federal contracting business, from initial setup through winning your first contracts.
              </p>
              <div class="flex flex-wrap items-center space-x-6 text-sm text-blue-200">
                <span>• 15 min read</span>
                <span>• Beginner to Intermediate</span>
                <span>• Setup, Strategy, Success</span>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- Article Categories -->
    <section class="py-16 bg-gray-50">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Article Categories
          </h2>
          <p class="text-lg text-gray-600">
            Browse articles by topic to find exactly what you need
          </p>
        </div>

        <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-6">
          <!-- Getting Started -->
          <div class="bg-white rounded-lg p-6 shadow-sm hover:shadow-md transition-shadow">
            <div class="flex items-center justify-center w-12 h-12 bg-blue-100 rounded-lg mb-4">
              <Icon name="heroicons:rocket-launch" class="w-6 h-6 text-blue-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-2">Getting Started</h3>
            <p class="text-gray-600 text-sm mb-4">
              Essential guides for businesses new to federal contracting
            </p>
            <div class="text-blue-700 text-sm font-medium">8 articles coming soon</div>
          </div>

          <!-- Best Practices -->
          <div class="bg-white rounded-lg p-6 shadow-sm hover:shadow-md transition-shadow">
            <div class="flex items-center justify-center w-12 h-12 bg-green-100 rounded-lg mb-4">
              <Icon name="heroicons:light-bulb" class="w-6 h-6 text-green-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-2">Best Practices</h3>
            <p class="text-gray-600 text-sm mb-4">
              Proven strategies and tactics from successful contractors
            </p>
            <div class="text-blue-700 text-sm font-medium">12 articles coming soon</div>
          </div>

          <!-- Compliance -->
          <div class="bg-white rounded-lg p-6 shadow-sm hover:shadow-md transition-shadow">
            <div class="flex items-center justify-center w-12 h-12 bg-orange-100 rounded-lg mb-4">
              <Icon name="heroicons:shield-check" class="w-6 h-6 text-orange-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-2">Compliance</h3>
            <p class="text-gray-600 text-sm mb-4">
              FAR requirements, regulations, and compliance guidance
            </p>
            <div class="text-blue-700 text-sm font-medium">10 articles coming soon</div>
          </div>

          <!-- Industry News -->
          <div class="bg-white rounded-lg p-6 shadow-sm hover:shadow-md transition-shadow">
            <div class="flex items-center justify-center w-12 h-12 bg-purple-100 rounded-lg mb-4">
              <Icon name="heroicons:megaphone" class="w-6 h-6 text-purple-700" />
            </div>
            <h3 class="text-lg font-semibold text-gray-900 mb-2">Industry News</h3>
            <p class="text-gray-600 text-sm mb-4">
              Latest updates and changes in federal procurement
            </p>
            <div class="text-blue-700 text-sm font-medium">Weekly updates</div>
          </div>
        </div>
      </div>
    </section>

    <!-- Recent Articles -->
    <section class="py-16 bg-white">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Recent Articles
          </h2>
          <p class="text-lg text-gray-600">
            Latest insights and guidance for federal contractors
          </p>
        </div>

        <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-8">
          <!-- Article 1 -->
          <article class="bg-gray-50 rounded-lg overflow-hidden hover:shadow-lg transition-shadow">
            <div class="p-6">
              <div class="flex items-center space-x-2 mb-3">
                <span class="bg-blue-100 text-blue-800 px-2 py-1 rounded text-xs font-medium">Getting Started</span>
                <span class="text-gray-500 text-xs">Coming Soon</span>
              </div>
              <h3 class="text-lg font-semibold text-gray-900 mb-3">
                5 Essential Steps Before Registering in SAM.gov
              </h3>
              <p class="text-gray-600 text-sm mb-4">
                Critical preparation steps that will save you time and prevent common registration mistakes that delay your federal contracting journey.
              </p>
              <div class="flex items-center justify-between text-sm text-gray-500">
                <span>5 min read</span>
                <span>Beginner</span>
              </div>
            </div>
          </article>

          <!-- Article 2 -->
          <article class="bg-gray-50 rounded-lg overflow-hidden hover:shadow-lg transition-shadow">
            <div class="p-6">
              <div class="flex items-center space-x-2 mb-3">
                <span class="bg-green-100 text-green-800 px-2 py-1 rounded text-xs font-medium">Best Practices</span>
                <span class="text-gray-500 text-xs">Coming Soon</span>
              </div>
              <h3 class="text-lg font-semibold text-gray-900 mb-3">
                How to Choose the Right NAICS Codes for Maximum Opportunities
              </h3>
              <p class="text-gray-600 text-sm mb-4">
                Strategic approach to NAICS code selection that opens doors to more opportunities while maintaining competitive advantages.
              </p>
              <div class="flex items-center justify-between text-sm text-gray-500">
                <span>8 min read</span>
                <span>Intermediate</span>
              </div>
            </div>
          </article>

          <!-- Article 3 -->
          <article class="bg-gray-50 rounded-lg overflow-hidden hover:shadow-lg transition-shadow">
            <div class="p-6">
              <div class="flex items-center space-x-2 mb-3">
                <span class="bg-purple-100 text-purple-800 px-2 py-1 rounded text-xs font-medium">Strategy</span>
                <span class="text-gray-500 text-xs">Coming Soon</span>
              </div>
              <h3 class="text-lg font-semibold text-gray-900 mb-3">
                The Contracting Officer's Perspective: What We Really Look For
              </h3>
              <p class="text-gray-600 text-sm mb-4">
                Insider insights from 15 years as a contracting officer on what separates winning proposals from the rest.
              </p>
              <div class="flex items-center justify-between text-sm text-gray-500">
                <span>12 min read</span>
                <span>All Levels</span>
              </div>
            </div>
          </article>

          <!-- Article 4 -->
          <article class="bg-gray-50 rounded-lg overflow-hidden hover:shadow-lg transition-shadow">
            <div class="p-6">
              <div class="flex items-center space-x-2 mb-3">
                <span class="bg-orange-100 text-orange-800 px-2 py-1 rounded text-xs font-medium">Compliance</span>
                <span class="text-gray-500 text-xs">Coming Soon</span>
              </div>
              <h3 class="text-lg font-semibold text-gray-900 mb-3">
                Top 10 FAR Compliance Mistakes That Cost Contractors
              </h3>
              <p class="text-gray-600 text-sm mb-4">
                Common compliance errors that can result in contract termination, penalties, or debarment - and how to avoid them.
              </p>
              <div class="flex items-center justify-between text-sm text-gray-500">
                <span>10 min read</span>
                <span>Intermediate</span>
              </div>
            </div>
          </article>

          <!-- Article 5 -->
          <article class="bg-gray-50 rounded-lg overflow-hidden hover:shadow-lg transition-shadow">
            <div class="p-6">
              <div class="flex items-center space-x-2 mb-3">
                <span class="bg-red-100 text-red-800 px-2 py-1 rounded text-xs font-medium">Case Study</span>
                <span class="text-gray-500 text-xs">Coming Soon</span>
              </div>
              <h3 class="text-lg font-semibold text-gray-900 mb-3">
                From Startup to $10M: A Federal Contracting Success Story
              </h3>
              <p class="text-gray-600 text-sm mb-4">
                How one small business grew from zero federal experience to $10M in contracts in just 3 years using strategic planning.
              </p>
              <div class="flex items-center justify-between text-sm text-gray-500">
                <span>15 min read</span>
                <span>All Levels</span>
              </div>
            </div>
          </article>

          <!-- Article 6 -->
          <article class="bg-gray-50 rounded-lg overflow-hidden hover:shadow-lg transition-shadow">
            <div class="p-6">
              <div class="flex items-center space-x-2 mb-3">
                <span class="bg-indigo-100 text-indigo-800 px-2 py-1 rounded text-xs font-medium">Tools</span>
                <span class="text-gray-500 text-xs">Coming Soon</span>
              </div>
              <h3 class="text-lg font-semibold text-gray-900 mb-3">
                Essential Tools and Resources for Federal Contractors
              </h3>
              <p class="text-gray-600 text-sm mb-4">
                Must-have tools, websites, and resources that every successful federal contractor uses to stay competitive.
              </p>
              <div class="flex items-center justify-between text-sm text-gray-500">
                <span>7 min read</span>
                <span>Beginner</span>
              </div>
            </div>
          </article>
        </div>
      </div>
    </section>

    <!-- Newsletter Signup -->
    <section class="py-16 bg-blue-700 text-white">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <Icon name="heroicons:envelope" class="w-12 h-12 mx-auto mb-6 opacity-80" />
        <h2 class="text-3xl font-bold mb-4">
          Never Miss an Update
        </h2>
        <p class="text-xl mb-8 opacity-90">
          Get new articles delivered directly to your inbox. No spam, just valuable federal contracting insights.
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
          Join 500+ federal contractors getting weekly insights.
        </p>
      </div>
    </section>

    <!-- Browse More -->
    <section class="py-16 bg-gray-50">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <h2 class="text-2xl font-bold text-gray-900 mb-4">
          Looking for Something Specific?
        </h2>
        <p class="text-lg text-gray-600 mb-8">
          Explore our other resource categories
        </p>
        <div class="flex flex-col sm:flex-row justify-center space-y-4 sm:space-y-0 sm:space-x-4">
          <NuxtLink 
            to="/resources/guides"
            class="inline-flex items-center justify-center px-6 py-3 bg-blue-700 text-white rounded-md hover:bg-blue-800 transition-colors font-medium"
          >
            <Icon name="heroicons:document-arrow-down" class="w-5 h-5 mr-2" />
            Browse Guides & Templates
          </NuxtLink>
          <NuxtLink 
            to="/resources/certifications"
            class="inline-flex items-center justify-center px-6 py-3 border border-blue-700 text-blue-700 rounded-md hover:bg-blue-50 transition-colors font-medium"
          >
            <Icon name="heroicons:trophy" class="w-5 h-5 mr-2" />
            Certification Help
          </NuxtLink>
        </div>
      </div>
    </section>
  </div>
</template>

<script setup>
// Set page meta for SEO
definePageMeta({
  title: 'Blog & Articles - True North Federal Solutions',
  description: 'Federal contracting blog with expert insights, best practices, and industry news for small businesses entering government contracting.'
})

// Set head for SEO
useHead({
  title: 'Federal Contracting Blog & Articles - True North Federal Solutions',
  meta: [
    { 
      name: 'description', 
      content: 'Expert federal contracting articles and insights from experienced contracting officers. Best practices, compliance guidance, and success strategies.' 
    },
    { 
      name: 'keywords', 
      content: 'federal contracting blog, government contracting articles, small business tips, FAR compliance, proposal writing, contracting best practices' 
    }
  ]
})
</script>