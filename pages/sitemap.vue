<template>
  <div>
    <Hero title="Site Map" subtitle="Navigate all areas of True North Federal Solutions"
      background-class="bg-gradient-to-r from-gray-600 to-gray-800" />

    <BaseSection>
      <div class="max-w-6xl mx-auto">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Complete Site Navigation
          </h2>
          <p class="text-xl text-gray-600">
            Find all the resources and information you need to succeed in federal contracting
          </p>
        </div>

        <div class="grid lg:grid-cols-2 gap-8">
          <!-- Main Pages -->
          <BaseCard>
            <div class="p-6">
              <h3 class="text-xl font-bold mb-4 flex items-center">
                <Icon name="heroicons:home" class="w-6 h-6 text-primary-600 mr-2" />
                Main Pages
              </h3>
              <div class="space-y-3">
                <NuxtLink to="/" class="block text-gray-700 hover:text-primary-600 transition-colors">
                  🏠 Home - Federal contracting expertise and guidance
                </NuxtLink>
                <NuxtLink to="/about" class="block text-gray-700 hover:text-primary-600 transition-colors">
                  👤 About - Our founder's background and mission
                </NuxtLink>
                <NuxtLink to="/contact" class="block text-gray-700 hover:text-primary-600 transition-colors">
                  📞 Contact - Get in touch for consultation
                </NuxtLink>
              </div>
            </div>
          </BaseCard>

          <!-- Services -->
          <BaseCard>
            <div class="p-6">
              <h3 class="text-xl font-bold mb-4 flex items-center">
                <Icon name="heroicons:briefcase" class="w-6 h-6 text-primary-600 mr-2" />
                Services
              </h3>
              <div class="space-y-3">
                <NuxtLink to="/services" class="block text-gray-700 hover:text-primary-600 transition-colors">
                  💼 Services Overview
                </NuxtLink>
                <div class="ml-4 space-y-2">
                  <NuxtLink to="/services/contract-setup"
                    class="block text-gray-600 hover:text-primary-600 transition-colors text-sm">
                    📋 Federal Contract Setup
                  </NuxtLink>
                  <NuxtLink to="/services/proposal-development"
                    class="block text-gray-600 hover:text-primary-600 transition-colors text-sm">
                    📝 Proposal Development
                  </NuxtLink>
                  <NuxtLink to="/services/far-compliance"
                    class="block text-gray-600 hover:text-primary-600 transition-colors text-sm">
                    ⚖️ FAR Compliance Consulting
                  </NuxtLink>
                  <NuxtLink to="/services/bid-no-bid-strategy"
                    class="block text-gray-600 hover:text-primary-600 transition-colors text-sm">
                    🎯 Bid/No-Bid Strategy
                  </NuxtLink>
                </div>
              </div>
            </div>
          </BaseCard>

          <!-- Resources -->
          <BaseCard>
            <div class="p-6">
              <h3 class="text-xl font-bold mb-4 flex items-center">
                <Icon name="heroicons:book-open" class="w-6 h-6 text-primary-600 mr-2" />
                Resources
              </h3>
              <div class="space-y-3">
                <NuxtLink to="/resources" class="block text-gray-700 hover:text-primary-600 transition-colors">
                  📚 Resource Hub Overview
                </NuxtLink>
                <div class="ml-4 space-y-2">
                  <NuxtLink to="/resources/blog"
                    class="block text-gray-600 hover:text-primary-600 transition-colors text-sm">
                    📰 Blog & Articles
                  </NuxtLink>
                  <NuxtLink to="/resources/guides"
                    class="block text-gray-600 hover:text-primary-600 transition-colors text-sm">
                    📖 Guides & Templates
                  </NuxtLink>
                  <NuxtLink to="/resources/certifications"
                    class="block text-gray-600 hover:text-primary-600 transition-colors text-sm">
                    🏆 Certification Help
                  </NuxtLink>
                  <div class="ml-4 space-y-1">
                    <NuxtLink to="/resources/certifications/wosb"
                      class="block text-gray-500 hover:text-primary-600 transition-colors text-xs">
                      👩‍💼 WOSB Guide
                    </NuxtLink>
                    <NuxtLink to="/resources/certifications/vosb"
                      class="block text-gray-500 hover:text-primary-600 transition-colors text-xs">
                      🎖️ VOSB Guide
                    </NuxtLink>
                    <NuxtLink to="/resources/certifications/8a"
                      class="block text-gray-500 hover:text-primary-600 transition-colors text-xs">
                      🔄 8(a) Program
                    </NuxtLink>
                  </div>
                </div>
              </div>
            </div>
          </BaseCard>

          <!-- Legal & Utility -->
          <BaseCard>
            <div class="p-6">
              <h3 class="text-xl font-bold mb-4 flex items-center">
                <Icon name="heroicons:document-text" class="w-6 h-6 text-primary-600 mr-2" />
                Legal & Utility
              </h3>
              <div class="space-y-3">
                <NuxtLink to="/privacy" class="block text-gray-700 hover:text-primary-600 transition-colors">
                  🔒 Privacy Policy
                </NuxtLink>
                <NuxtLink to="/terms" class="block text-gray-700 hover:text-primary-600 transition-colors">
                  📜 Terms of Service
                </NuxtLink>
                <NuxtLink to="/accessibility" class="block text-gray-700 hover:text-primary-600 transition-colors">
                  ♿ Accessibility Statement
                </NuxtLink>
                <NuxtLink to="/sitemap" class="block text-gray-700 hover:text-primary-600 transition-colors">
                  🗺️ Site Map (This Page)
                </NuxtLink>
              </div>
            </div>
          </BaseCard>
        </div>

        <!-- Quick Links Section -->
        <div class="mt-12">
          <h3 class="text-2xl font-bold mb-6 text-center">Quick Links</h3>
          <div class="grid md:grid-cols-3 gap-6">
            <BaseCard class="text-center p-6">
              <Icon name="heroicons:rocket-launch" class="w-12 h-12 text-primary-600 mb-4 mx-auto" />
              <h4 class="font-semibold mb-3">Get Started</h4>
              <p class="text-gray-600 text-sm mb-4">New to federal contracting? Start here.</p>
              <BaseButton variant="outline" size="sm">
                <NuxtLink to="/services">Explore Services</NuxtLink>
              </BaseButton>
            </BaseCard>

            <BaseCard class="text-center p-6">
              <Icon name="heroicons:academic-cap" class="w-12 h-12 text-primary-600 mb-4 mx-auto" />
              <h4 class="font-semibold mb-3">Learn</h4>
              <p class="text-gray-600 text-sm mb-4">Access guides, articles, and resources.</p>
              <BaseButton variant="outline" size="sm">
                <NuxtLink to="/resources">View Resources</NuxtLink>
              </BaseButton>
            </BaseCard>

            <BaseCard class="text-center p-6">
              <Icon name="heroicons:phone" class="w-12 h-12 text-primary-600 mb-4 mx-auto" />
              <h4 class="font-semibold mb-3">Connect</h4>
              <p class="text-gray-600 text-sm mb-4">Ready to discuss your needs?</p>
              <BaseButton variant="primary" size="sm">
                <NuxtLink to="/contact">Contact Us</NuxtLink>
              </BaseButton>
            </BaseCard>
          </div>
        </div>

        <!-- Search Section -->
        <div class="mt-12 bg-gray-50 rounded-lg p-8 text-center">
          <h3 class="text-2xl font-bold mb-4">Can't Find What You're Looking For?</h3>
          <p class="text-gray-600 mb-6">
            Use our search feature or contact us directly for assistance finding the right resources.
          </p>
          <div class="flex flex-wrap justify-center gap-4">
            <BaseButton variant="outline">
              Search Site
            </BaseButton>
            <BaseButton variant="primary">
              <NuxtLink to="/contact">Contact Support</NuxtLink>
            </BaseButton>
          </div>
        </div>

        <!-- Last Updated -->
        <div class="mt-8 text-center text-sm text-gray-500">
          <p>Site Map last updated: December 2024</p>
        </div>
      </div>
    </BaseSection>
  </div>
</template>

<script setup>
definePageMeta({
  title: 'Site Map',
  description: 'Complete navigation guide for True North Federal Solutions website, including all pages and resources.'
})
</script>