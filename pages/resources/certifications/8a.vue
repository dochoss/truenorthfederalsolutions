<template>
  <div>
    <Hero 
      title="8(a) Business Development Program"
      subtitle="Complete guide to the SBA's 8(a) program for socially and economically disadvantaged businesses"
      background-class="bg-gradient-to-r from-green-600 to-green-800"
    />
    
    <BaseSection>
      <div class="max-w-4xl mx-auto">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Accelerate Your Business Growth with the 8(a) Program
          </h2>
          <p class="text-xl text-gray-600">
            The SBA's 8(a) Business Development Program is a nine-year program designed to help socially and economically disadvantaged small businesses compete in the federal marketplace.
          </p>
        </div>

        <!-- Quick Stats -->
        <UCard class="mb-12">
          <div class="p-8">
            <h3 class="text-2xl font-bold mb-6 text-center">8(a) Program Impact</h3>
            <div class="grid md:grid-cols-3 gap-8 text-center">
              <div>
                <div class="text-3xl font-bold text-green-600">5%</div>
                <div class="text-sm text-gray-600">Federal contracting goal for disadvantaged businesses</div>
              </div>
              <div>
                <div class="text-3xl font-bold text-green-600">$35B+</div>
                <div class="text-sm text-gray-600">Annual 8(a) contract awards</div>
              </div>
              <div>
                <div class="text-3xl font-bold text-green-600">9</div>
                <div class="text-sm text-gray-600">Years of program participation</div>
              </div>
            </div>
          </div>
        </UCard>

        <!-- Program Overview -->
        <div class="space-y-12">
          <div>
            <h3 class="text-2xl font-bold mb-6">What is the 8(a) Program?</h3>
            <UCard>
              <div class="p-6">
                <p class="text-gray-600 mb-4">
                  The 8(a) Business Development Program is a robust nine-year program created to help firms owned and controlled by socially and economically disadvantaged individuals. The program offers a broad scope of assistance including training, counseling, marketing assistance, and high-level executive development.
                </p>
                <p class="text-gray-600">
                  One of the program's most significant benefits is providing participating businesses with access to government contracting opportunities through set-aside contracts and sole-source awards.
                </p>
              </div>
            </UCard>
          </div>

          <!-- Program Phases -->
          <div>
            <h3 class="text-2xl font-bold mb-6">9-Year Program Structure</h3>
            <div class="space-y-6">
              <UCard>
                <div class="p-6">
                  <div class="flex items-center mb-4">
                    <div class="w-10 h-10 bg-green-100 rounded-full flex items-center justify-center mr-4">
                      <span class="text-green-600 font-bold">1</span>
                    </div>
                    <h4 class="text-lg font-semibold">Developmental Stage (Years 1-4)</h4>
                  </div>
                  <p class="text-gray-600 mb-3">
                    Focus on business development through training, counseling, and limited competition opportunities.
                  </p>
                  <ul class="text-sm text-gray-600 space-y-1">
                    <li>• Intensive business development assistance</li>
                    <li>• Access to sole-source contracts up to $4.5 million</li>
                    <li>• Set-aside contract opportunities</li>
                    <li>• Management and technical assistance</li>
                  </ul>
                </div>
              </UCard>

              <UCard>
                <div class="p-6">
                  <div class="flex items-center mb-4">
                    <div class="w-10 h-10 bg-green-100 rounded-full flex items-center justify-center mr-4">
                      <span class="text-green-600 font-bold">2</span>
                    </div>
                    <h4 class="text-lg font-semibold">Transitional Stage (Years 5-9)</h4>
                  </div>
                  <p class="text-gray-600 mb-3">
                    Emphasis on competitive market preparation and gradual transition to full competition.
                  </p>
                  <ul class="text-sm text-gray-600 space-y-1">
                    <li>• Continued access to 8(a) contracts</li>
                    <li>• Competitive experience requirements</li>
                    <li>• Business mix targets (competitive vs. sole-source)</li>
                    <li>• Graduate preparation activities</li>
                  </ul>
                </div>
              </UCard>
            </div>
          </div>

          <!-- Eligibility Requirements -->
          <div>
            <h3 class="text-2xl font-bold mb-6">Eligibility Requirements</h3>
            <div class="grid md:grid-cols-2 gap-6">
              <UCard>
                <div class="p-6">
                  <h4 class="text-lg font-semibold mb-4 flex items-center">
                    <UIcon name="i-heroicons-user-group" class="w-6 h-6 text-green-600 mr-2" />
                    Social Disadvantage
                  </h4>
                  <ul class="space-y-2 text-gray-600">
                    <li>• Member of a designated group (Black Americans, Hispanic Americans, Native Americans, Asian Pacific Americans, and Subcontinent Asian Americans)</li>
                    <li>• Or demonstrate individual social disadvantage</li>
                    <li>• Must have experienced bias or barriers to success</li>
                  </ul>
                </div>
              </UCard>

              <UCard>
                <div class="p-6">
                  <h4 class="text-lg font-semibold mb-4 flex items-center">
                    <UIcon name="i-heroicons-currency-dollar" class="w-6 h-6 text-green-600 mr-2" />
                    Economic Disadvantage
                  </h4>
                  <ul class="space-y-2 text-gray-600">
                    <li>• Personal net worth less than $850,000</li>
                    <li>• Personal income averaged less than $400,000 for 3 years</li>
                    <li>• Fair market value of assets less than $6.5 million</li>
                  </ul>
                </div>
              </UCard>

              <UCard>
                <div class="p-6">
                  <h4 class="text-lg font-semibold mb-4 flex items-center">
                    <UIcon name="i-heroicons-building-office" class="w-6 h-6 text-green-600 mr-2" />
                    Business Requirements
                  </h4>
                  <ul class="space-y-2 text-gray-600">
                    <li>• Must be small business by SBA standards</li>
                    <li>• 51% owned by disadvantaged individuals</li>
                    <li>• Management and daily operations controlled by disadvantaged owners</li>
                    <li>• In business for at least 2 years</li>
                  </ul>
                </div>
              </UCard>

              <UCard>
                <div class="p-6">
                  <h4 class="text-lg font-semibold mb-4 flex items-center">
                    <UIcon name="i-heroicons-check-circle" class="w-6 h-6 text-green-600 mr-2" />
                    Additional Criteria
                  </h4>
                  <ul class="space-y-2 text-gray-600">
                    <li>• Good character (pass character review)</li>
                    <li>• Potential for success</li>
                    <li>• Principal place of business in US</li>
                    <li>• Not previously participated in 8(a)</li>
                  </ul>
                </div>
              </UCard>
            </div>
          </div>

          <!-- Application Process -->
          <div>
            <h3 class="text-2xl font-bold mb-6">Application Process</h3>
            <UCard>
              <div class="p-6">
                <div class="space-y-6">
                  <div class="flex items-start">
                    <div class="flex-shrink-0 w-8 h-8 bg-green-100 rounded-full flex items-center justify-center mr-4">
                      <span class="text-green-600 font-semibold">1</span>
                    </div>
                    <div>
                      <h4 class="font-semibold mb-2">Initial Assessment</h4>
                      <p class="text-gray-600">Review eligibility requirements and conduct a preliminary self-assessment to determine qualification likelihood.</p>
                    </div>
                  </div>
                  
                  <div class="flex items-start">
                    <div class="flex-shrink-0 w-8 h-8 bg-green-100 rounded-full flex items-center justify-center mr-4">
                      <span class="text-green-600 font-semibold">2</span>
                    </div>
                    <div>
                      <h4 class="font-semibold mb-2">Document Preparation</h4>
                      <p class="text-gray-600">Gather extensive documentation including financial records, tax returns, personal history, and business plans.</p>
                    </div>
                  </div>
                  
                  <div class="flex items-start">
                    <div class="flex-shrink-0 w-8 h-8 bg-green-100 rounded-full flex items-center justify-center mr-4">
                      <span class="text-green-600 font-semibold">3</span>
                    </div>
                    <div>
                      <h4 class="font-semibold mb-2">Online Application</h4>
                      <p class="text-gray-600">Complete the comprehensive application through SBA's certify.sba.gov portal.</p>
                    </div>
                  </div>
                  
                  <div class="flex items-start">
                    <div class="flex-shrink-0 w-8 h-8 bg-green-100 rounded-full flex items-center justify-center mr-4">
                      <span class="text-green-600 font-semibold">4</span>
                    </div>
                    <div>
                      <h4 class="font-semibold mb-2">Review Process</h4>
                      <p class="text-gray-600">SBA conducts a thorough review (typically 90+ days) including site visits and interviews.</p>
                    </div>
                  </div>
                </div>
              </div>
            </UCard>
          </div>

          <!-- Benefits -->
          <div>
            <h3 class="text-2xl font-bold mb-6">Program Benefits</h3>
            <div class="grid md:grid-cols-3 gap-6">
              <UCard class="text-center p-6">
                <UIcon name="i-heroicons-target" class="w-12 h-12 text-green-600 mb-4 mx-auto" />
                <h4 class="font-semibold mb-3">Sole-Source Contracts</h4>
                <p class="text-gray-600 text-sm">Up to $4.5 million for services and $7 million for manufacturing without competition</p>
              </UCard>

              <UCard class="text-center p-6">
                <UIcon name="i-heroicons-academic-cap" class="w-12 h-12 text-green-600 mb-4 mx-auto" />
                <h4 class="font-semibold mb-3">Business Development</h4>
                <p class="text-gray-600 text-sm">Comprehensive training, counseling, and mentorship opportunities</p>
              </UCard>

              <UCard class="text-center p-6">
                <UIcon name="i-heroicons-users" class="w-12 h-12 text-green-600 mb-4 mx-auto" />
                <h4 class="font-semibold mb-3">Networking</h4>
                <p class="text-gray-600 text-sm">Access to exclusive networking events and business relationships</p>
              </UCard>
            </div>
          </div>

          <!-- Common Challenges -->
          <div>
            <h3 class="text-2xl font-bold mb-6">Common Application Challenges</h3>
            <UCard>
              <div class="p-6">
                <div class="space-y-4">
                  <div class="flex items-start">
                    <UIcon name="i-heroicons-exclamation-triangle" class="w-6 h-6 text-amber-500 mr-3 mt-1 flex-shrink-0" />
                    <div>
                      <h4 class="font-semibold mb-1">Complex Documentation</h4>
                      <p class="text-gray-600 text-sm">Extensive personal and business documentation requirements can be overwhelming</p>
                    </div>
                  </div>
                  
                  <div class="flex items-start">
                    <UIcon name="i-heroicons-exclamation-triangle" class="w-6 h-6 text-amber-500 mr-3 mt-1 flex-shrink-0" />
                    <div>
                      <h4 class="font-semibold mb-1">Economic Disadvantage Proof</h4>
                      <p class="text-gray-600 text-sm">Demonstrating economic disadvantage while maintaining business viability</p>
                    </div>
                  </div>
                  
                  <div class="flex items-start">
                    <UIcon name="i-heroicons-exclamation-triangle" class="w-6 h-6 text-amber-500 mr-3 mt-1 flex-shrink-0" />
                    <div>
                      <h4 class="font-semibold mb-1">Lengthy Review Process</h4>
                      <p class="text-gray-600 text-sm">Application review can take 90+ days with potential for additional documentation requests</p>
                    </div>
                  </div>
                </div>
              </div>
            </UCard>
          </div>

          <!-- Next Steps -->
          <div class="bg-green-50 rounded-lg p-8">
            <h3 class="text-2xl font-bold text-green-900 mb-4 text-center">
              Ready to Apply for the 8(a) Program?
            </h3>
            <p class="text-green-700 text-center mb-6">
              The 8(a) application process is complex and detailed. Our experienced team can help you navigate the requirements and maximize your chances of acceptance.
            </p>
            <div class="flex flex-wrap justify-center gap-4">
              <UButton color="primary" to="/contact">
                Schedule Consultation
              </UButton>
              <UButton variant="outline">
                Download 8(a) Guide
              </UButton>
            </div>
          </div>
        </div>
      </div>
    </BaseSection>
  </div>
</template>

<script setup>
definePageMeta({
  title: '8(a) Program Guide',
  description: 'Complete guide to the SBA 8(a) Business Development Program for socially and economically disadvantaged small businesses.'
})
</script>