<template>
  <div>
    <Hero 
      title="Federal Contracting Blog"
      subtitle="Insights, tips, and industry updates for government contractors"
      background-class="bg-gradient-to-r from-indigo-600 to-indigo-800"
    />
    
    <BaseSection>
      <div class="max-w-6xl mx-auto">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Latest Insights & Updates
          </h2>
          <p class="text-xl text-gray-600">
            Stay informed with the latest trends, regulations, and best practices in federal contracting
          </p>
        </div>

        <!-- Featured Article -->
        <UCard class="mb-12">
          <div class="p-8">
            <div class="flex items-center mb-4">
              <span class="bg-indigo-100 text-indigo-800 text-sm font-medium px-3 py-1 rounded-full">Featured</span>
              <span class="text-gray-500 ml-4">December 15, 2024</span>
            </div>
            <h3 class="text-2xl font-bold mb-4">
              New FAR Changes for 2025: What Contractors Need to Know
            </h3>
            <p class="text-gray-600 mb-6">
              The latest updates to the Federal Acquisition Regulation bring significant changes that will impact how contractors approach federal opportunities. Learn about the key modifications and how to ensure compliance in your next proposal.
            </p>
            <UButton variant="outline">
              Read Full Article
            </UButton>
          </div>
        </UCard>

        <!-- Blog Categories -->
        <div class="grid md:grid-cols-4 gap-6 mb-12">
          <UCard class="text-center p-6 hover:shadow-lg transition-shadow">
            <UIcon name="i-heroicons-document-text" class="w-12 h-12 text-indigo-600 mb-4 mx-auto" />
            <h3 class="font-semibold mb-2">Proposal Writing</h3>
            <p class="text-sm text-gray-600">Tips and strategies for winning proposals</p>
          </UCard>

          <UCard class="text-center p-6 hover:shadow-lg transition-shadow">
            <UIcon name="i-heroicons-scale" class="w-12 h-12 text-indigo-600 mb-4 mx-auto" />
            <h3 class="font-semibold mb-2">Compliance</h3>
            <p class="text-sm text-gray-600">Regulatory updates and compliance guidance</p>
          </UCard>

          <UCard class="text-center p-6 hover:shadow-lg transition-shadow">
            <UIcon name="i-heroicons-chart-bar" class="w-12 h-12 text-indigo-600 mb-4 mx-auto" />
            <h3 class="font-semibold mb-2">Business Strategy</h3>
            <p class="text-sm text-gray-600">Growth strategies for federal contractors</p>
          </UCard>

          <UCard class="text-center p-6 hover:shadow-lg transition-shadow">
            <UIcon name="i-heroicons-light-bulb" class="w-12 h-12 text-indigo-600 mb-4 mx-auto" />
            <h3 class="font-semibold mb-2">Industry Insights</h3>
            <p class="text-sm text-gray-600">Market trends and opportunities</p>
          </UCard>
        </div>

        <!-- Recent Articles -->
        <div class="grid md:grid-cols-2 lg:grid-cols-3 gap-8">
          <UCard>
            <div class="p-6">
              <div class="text-sm text-gray-500 mb-2">December 10, 2024</div>
              <h3 class="text-lg font-semibold mb-3">
                5 Common Proposal Mistakes That Cost You Contracts
              </h3>
              <p class="text-gray-600 mb-4">
                Avoid these critical errors that can sink even the most technically sound proposals.
              </p>
              <UButton variant="outline" size="sm">
                Read More
              </UButton>
            </div>
          </UCard>

          <UCard>
            <div class="p-6">
              <div class="text-sm text-gray-500 mb-2">December 5, 2024</div>
              <h3 class="text-lg font-semibold mb-3">
                Understanding Small Business Set-Asides in 2025
              </h3>
              <p class="text-gray-600 mb-4">
                Navigate the changing landscape of small business contracting opportunities.
              </p>
              <UButton variant="outline" size="sm">
                Read More
              </UButton>
            </div>
          </UCard>

          <UCard>
            <div class="p-6">
              <div class="text-sm text-gray-500 mb-2">November 28, 2024</div>
              <h3 class="text-lg font-semibold mb-3">
                Cybersecurity Requirements: CMMC 2.0 Updates
              </h3>
              <p class="text-gray-600 mb-4">
                Latest developments in cybersecurity compliance for defense contractors.
              </p>
              <UButton variant="outline" size="sm">
                Read More
              </UButton>
            </div>
          </UCard>

          <UCard>
            <div class="p-6">
              <div class="text-sm text-gray-500 mb-2">November 20, 2024</div>
              <h3 class="text-lg font-semibold mb-3">
                Building Winning Past Performance Narratives
              </h3>
              <p class="text-gray-600 mb-4">
                How to craft compelling past performance examples that differentiate your proposal.
              </p>
              <UButton variant="outline" size="sm">
                Read More
              </UButton>
            </div>
          </UCard>

          <UCard>
            <div class="p-6">
              <div class="text-sm text-gray-500 mb-2">November 15, 2024</div>
              <h3 class="text-lg font-semibold mb-3">
                GSA Schedule Updates and Opportunities
              </h3>
              <p class="text-gray-600 mb-4">
                Recent changes to GSA Schedules and how to leverage them for growth.
              </p>
              <UButton variant="outline" size="sm">
                Read More
              </UButton>
            </div>
          </UCard>

          <UCard>
            <div class="p-6">
              <div class="text-sm text-gray-500 mb-2">November 8, 2024</div>
              <h3 class="text-lg font-semibold mb-3">
                Effective Teaming Strategies for Large Contracts
              </h3>
              <p class="text-gray-600 mb-4">
                Building successful partnerships to compete for larger federal opportunities.
              </p>
              <UButton variant="outline" size="sm">
                Read More
              </UButton>
            </div>
          </UCard>
        </div>

        <!-- Newsletter Signup -->
        <div class="bg-indigo-50 rounded-lg p-8 mt-12 text-center">
          <h3 class="text-2xl font-bold text-indigo-900 mb-4">
            Stay Updated
          </h3>
          <p class="text-indigo-700 mb-6">
            Get the latest federal contracting insights delivered to your inbox weekly
          </p>
          <div class="max-w-md mx-auto">
            <UButton color="primary" size="lg" class="w-full">
              Subscribe to Newsletter
            </UButton>
          </div>
        </div>
      </div>
    </BaseSection>
  </div>
</template>

<script setup>
definePageMeta({
  title: 'Federal Contracting Blog',
  description: 'Insights, tips, and industry updates for government contractors and federal contracting professionals.'
})
</script>
