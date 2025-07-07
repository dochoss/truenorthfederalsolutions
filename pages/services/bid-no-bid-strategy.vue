<template>
  <div>
    <Hero 
      title="Bid/No-Bid Strategy"
      subtitle="Make informed decisions about which opportunities to pursue for maximum ROI"
      background-class="bg-gradient-to-r from-purple-600 to-purple-800"
    />
    
    <BaseSection>
      <div class="max-w-4xl mx-auto">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Strategic Opportunity Assessment
          </h2>
          <p class="text-xl text-gray-600">
            Data-driven bid/no-bid analysis to optimize your business development efforts
          </p>
        </div>

        <div class="grid md:grid-cols-3 gap-8 mb-12">
          <BaseCard>
            <div class="p-6 text-center">
              <Icon name="heroicons:magnifying-glass" class="w-12 h-12 text-purple-600 mb-4 mx-auto" />
              <h3 class="text-xl font-semibold mb-3">Market Analysis</h3>
              <p class="text-gray-600">
                Comprehensive market research and competitive intelligence gathering.
              </p>
            </div>
          </BaseCard>

          <BaseCard>
            <div class="p-6 text-center">
              <Icon name="heroicons:calculator" class="w-12 h-12 text-purple-600 mb-4 mx-auto" />
              <h3 class="text-xl font-semibold mb-3">ROI Assessment</h3>
              <p class="text-gray-600">
                Calculate potential return on investment for each opportunity.
              </p>
            </div>
          </BaseCard>

          <BaseCard>
            <div class="p-6 text-center">
              <Icon name="heroicons:chart-pie" class="w-12 h-12 text-purple-600 mb-4 mx-auto" />
              <h3 class="text-xl font-semibold mb-3">Win Probability</h3>
              <p class="text-gray-600">
                Statistical analysis to determine likelihood of winning each bid.
              </p>
            </div>
          </BaseCard>
        </div>

        <div class="bg-purple-50 rounded-lg p-8 mb-12">
          <h3 class="text-2xl font-bold text-purple-900 mb-6">Our Decision Framework</h3>
          <div class="space-y-6">
            <div class="flex items-start">
              <div class="flex-shrink-0 w-8 h-8 bg-purple-600 text-white rounded-full flex items-center justify-center font-bold">
                1
              </div>
              <div class="ml-4">
                <h4 class="font-semibold text-purple-900">Opportunity Evaluation</h4>
                <p class="text-purple-700">Assess contract value, duration, and strategic alignment with your capabilities.</p>
              </div>
            </div>
            <div class="flex items-start">
              <div class="flex-shrink-0 w-8 h-8 bg-purple-600 text-white rounded-full flex items-center justify-center font-bold">
                2
              </div>
              <div class="ml-4">
                <h4 class="font-semibold text-purple-900">Competitive Analysis</h4>
                <p class="text-purple-700">Identify competitors and analyze their strengths, weaknesses, and past performance.</p>
              </div>
            </div>
            <div class="flex items-start">
              <div class="flex-shrink-0 w-8 h-8 bg-purple-600 text-white rounded-full flex items-center justify-center font-bold">
                3
              </div>
              <div class="ml-4">
                <h4 class="font-semibold text-purple-900">Resource Requirements</h4>
                <p class="text-purple-700">Calculate the time, personnel, and financial resources needed for proposal development.</p>
              </div>
            </div>
            <div class="flex items-start">
              <div class="flex-shrink-0 w-8 h-8 bg-purple-600 text-white rounded-full flex items-center justify-center font-bold">
                4
              </div>
              <div class="ml-4">
                <h4 class="font-semibold text-purple-900">Strategic Recommendation</h4>
                <p class="text-purple-700">Provide clear bid/no-bid recommendation with supporting rationale and action plan.</p>
              </div>
            </div>
          </div>
        </div>

        <div class="grid md:grid-cols-2 gap-8 mb-12">
          <BaseCard>
            <div class="p-6">
              <h3 class="text-xl font-semibold mb-4 text-green-700">Benefits of Strategic Bidding</h3>
              <ul class="space-y-2">
                <li class="flex items-center">
                  <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mr-2" />
                  <span>Higher win rates</span>
                </li>
                <li class="flex items-center">
                  <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mr-2" />
                  <span>Reduced proposal costs</span>
                </li>
                <li class="flex items-center">
                  <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mr-2" />
                  <span>Better resource allocation</span>
                </li>
                <li class="flex items-center">
                  <Icon name="heroicons:check-circle" class="w-5 h-5 text-green-600 mr-2" />
                  <span>Improved ROI</span>
                </li>
              </ul>
            </div>
          </BaseCard>

          <BaseCard>
            <div class="p-6">
              <h3 class="text-xl font-semibold mb-4 text-red-700">Risks of Poor Decisions</h3>
              <ul class="space-y-2">
                <li class="flex items-center">
                  <Icon name="heroicons:x-circle" class="w-5 h-5 text-red-600 mr-2" />
                  <span>Wasted proposal investment</span>
                </li>
                <li class="flex items-center">
                  <Icon name="heroicons:x-circle" class="w-5 h-5 text-red-600 mr-2" />
                  <span>Missed profitable opportunities</span>
                </li>
                <li class="flex items-center">
                  <Icon name="heroicons:x-circle" class="w-5 h-5 text-red-600 mr-2" />
                  <span>Resource overextension</span>
                </li>
                <li class="flex items-center">
                  <Icon name="heroicons:x-circle" class="w-5 h-5 text-red-600 mr-2" />
                  <span>Lower win rates</span>
                </li>
              </ul>
            </div>
          </BaseCard>
        </div>

        <div class="text-center">
          <p class="text-lg text-gray-600 mb-8">
            Make smarter bidding decisions with expert strategy support
          </p>
          <BaseButton variant="primary" size="lg">
            <NuxtLink to="/contact">Request Strategy Session</NuxtLink>
          </BaseButton>
        </div>
      </div>
    </BaseSection>
  </div>
</template>

<script setup>
definePageMeta({
  title: 'Bid/No-Bid Strategy Services',
  description: 'Strategic opportunity assessment and bid/no-bid decision support for government contractors.'
})
</script>
