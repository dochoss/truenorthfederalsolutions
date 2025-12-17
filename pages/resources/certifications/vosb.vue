<template>
  <div>
    <Hero 
      title="Veteran-Owned Small Business (VOSB) Certification"
      subtitle="Complete guide to obtaining and leveraging VOSB certification for federal contracting opportunities"
      background-class="bg-gradient-to-r from-red-600 to-red-800"
    />
    
    <UPageSection>
      <div class="max-w-4xl mx-auto">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Honor Your Service with VOSB Federal Contracting Opportunities
          </h2>
          <p class="text-xl text-gray-600">
            The Veteran-Owned Small Business (VOSB) program provides opportunities for veteran-owned businesses to compete for federal contracts and leverage their military experience in the business world.
          </p>
        </div>

        <!-- Quick Stats -->
        <UCard class="mb-12">
          <div class="p-8">
            <h3 class="text-2xl font-bold mb-6 text-center">VOSB Program Impact</h3>
            <div class="grid md:grid-cols-3 gap-8 text-center">
              <div>
                <div class="text-3xl font-bold text-red-600">3%</div>
                <div class="text-sm text-gray-600">Federal contracting goal for VOSBs</div>
              </div>
              <div>
                <div class="text-3xl font-bold text-red-600">$18B+</div>
                <div class="text-sm text-gray-600">Annual VOSB contract awards</div>
              </div>
              <div>
                <div class="text-3xl font-bold text-red-600">2.5M</div>
                <div class="text-sm text-gray-600">Veteran-owned businesses in the US</div>
              </div>
            </div>
          </div>
        </UCard>

        <!-- Program Overview -->
        <div class="space-y-12">
          <div>
            <h3 class="text-2xl font-bold mb-6">What is VOSB Certification?</h3>
            <UCard>
              <div class="p-6">
                <p class="text-gray-600 mb-4">
                  The Veterans First Contracting Program helps ensure that veteran-owned small businesses have the opportunity to compete for federal contracts. The program includes both VOSB (Veteran-Owned Small Business) and SDVOSB (Service-Disabled Veteran-Owned Small Business) certifications.
                </p>
                <p class="text-gray-600">
                  VOSB certification recognizes businesses owned and controlled by veterans, providing access to set-aside contracts and sole-source opportunities up to certain thresholds.
                </p>
              </div>
            </UCard>
          </div>

          <!-- Program Types -->
          <div>
            <h3 class="text-2xl font-bold mb-6">Types of Veteran Business Certifications</h3>
            <div class="grid md:grid-cols-2 gap-6">
              <UCard>
                <div class="p-6">
                  <h4 class="text-lg font-semibold mb-4 flex items-center">
                    <UIcon name="i-heroicons-shield-check" class="w-6 h-6 text-red-600 mr-2" />
                    VOSB (Veteran-Owned Small Business)
                  </h4>
                  <ul class="space-y-2 text-gray-600 mb-4">
                    <li>• Owned and controlled by veterans</li>
                    <li>• Access to VOSB set-aside contracts</li>
                    <li>• Verification through VA or SBA</li>
                    <li>• Must meet small business size standards</li>
                  </ul>
                  <div class="bg-red-50 p-3 rounded-lg">
                    <p class="text-red-700 text-sm"><strong>Best for:</strong> All qualifying veteran-owned businesses</p>
                  </div>
                </div>
              </UCard>

              <UCard>
                <div class="p-6">
                  <h4 class="text-lg font-semibold mb-4 flex items-center">
                    <UIcon name="i-heroicons-star" class="w-6 h-6 text-red-600 mr-2" />
                    SDVOSB (Service-Disabled Veteran-Owned)
                  </h4>
                  <ul class="space-y-2 text-gray-600 mb-4">
                    <li>• Owned by service-disabled veterans</li>
                    <li>• Priority in federal contracting</li>
                    <li>• Higher sole-source thresholds</li>
                    <li>• Additional contracting preferences</li>
                  </ul>
                  <div class="bg-red-50 p-3 rounded-lg">
                    <p class="text-red-700 text-sm"><strong>Best for:</strong> Veterans with service-connected disabilities</p>
                  </div>
                </div>
              </UCard>
            </div>
          </div>

          <!-- Eligibility Requirements -->
          <div>
            <h3 class="text-2xl font-bold mb-6">VOSB Eligibility Requirements</h3>
            <UCard>
              <div class="p-6">
                <div class="grid md:grid-cols-2 gap-6">
                  <div>
                    <h4 class="font-semibold mb-3">Ownership Requirements</h4>
                    <ul class="space-y-2 text-gray-600">
                      <li>• At least 51% owned by veterans</li>
                      <li>• Veterans must hold the highest officer position</li>
                      <li>• Veterans must control management and operations</li>
                      <li>• Ownership must be direct and unconditional</li>
                    </ul>
                  </div>
                  <div>
                    <h4 class="font-semibold mb-3">Business Requirements</h4>
                    <ul class="space-y-2 text-gray-600">
                      <li>• Must qualify as a small business</li>
                      <li>• Principal place of business in the US</li>
                      <li>• Veteran must have management experience</li>
                      <li>• Business must be for-profit</li>
                    </ul>
                  </div>
                </div>
              </div>
            </UCard>
          </div>

          <!-- Verification Process -->
          <div>
            <h3 class="text-2xl font-bold mb-6">Verification Process</h3>
            <UCard>
              <div class="p-6">
                <div class="space-y-6">
                  <div class="flex items-start">
                    <div class="shrink-0 w-8 h-8 bg-red-100 rounded-full flex items-center justify-center mr-4">
                      <span class="text-red-600 font-semibold">1</span>
                    </div>
                    <div>
                      <h4 class="font-semibold mb-2">Choose Verification Path</h4>
                      <p class="text-gray-600">Select VA's VetBiz VIP Database or SBA's certification program for verification.</p>
                    </div>
                  </div>
                  
                  <div class="flex items-start">
                    <div class="shrink-0 w-8 h-8 bg-red-100 rounded-full flex items-center justify-center mr-4">
                      <span class="text-red-600 font-semibold">2</span>
                    </div>
                    <div>
                      <h4 class="font-semibold mb-2">Prepare Documentation</h4>
                      <p class="text-gray-600">Gather DD-214, business formation documents, financial records, and organizational charts.</p>
                    </div>
                  </div>
                  
                  <div class="flex items-start">
                    <div class="shrink-0 w-8 h-8 bg-red-100 rounded-full flex items-center justify-center mr-4">
                      <span class="text-red-600 font-semibold">3</span>
                    </div>
                    <div>
                      <h4 class="font-semibold mb-2">Submit Application</h4>
                      <p class="text-gray-600">Complete the online application and upload all required supporting documents.</p>
                    </div>
                  </div>
                  
                  <div class="flex items-start">
                    <div class="shrink-0 w-8 h-8 bg-red-100 rounded-full flex items-center justify-center mr-4">
                      <span class="text-red-600 font-semibold">4</span>
                    </div>
                    <div>
                      <h4 class="font-semibold mb-2">Maintain Status</h4>
                      <p class="text-gray-600">Keep your verification current with periodic reviews and updates as required.</p>
                    </div>
                  </div>
                </div>
              </div>
            </UCard>
          </div>

          <!-- Benefits -->
          <div>
            <h3 class="text-2xl font-bold mb-6">Benefits of VOSB Verification</h3>
            <div class="grid md:grid-cols-3 gap-6">
              <UCard class="text-center p-6">
                <UIcon name="i-heroicons-flag" class="w-12 h-12 text-red-600 mb-4 mx-auto" />
                <h4 class="font-semibold mb-3">Set-Aside Contracts</h4>
                <p class="text-gray-600 text-sm">Access to contracts specifically reserved for veteran-owned businesses</p>
              </UCard>

              <UCard class="text-center p-6">
                <UIcon name="i-heroicons-bolt" class="w-12 h-12 text-red-600 mb-4 mx-auto" />
                <h4 class="font-semibold mb-3">Sole Source Awards</h4>
                <p class="text-gray-600 text-sm">Eligible for sole-source contracts up to $5 million for SDVOSB ($4 million for VOSB)</p>
              </UCard>

              <UCard class="text-center p-6">
                <UIcon name="i-heroicons-trophy" class="w-12 h-12 text-red-600 mb-4 mx-auto" />
                <h4 class="font-semibold mb-3">Competitive Advantage</h4>
                <p class="text-gray-600 text-sm">Priority consideration in federal procurement competitions</p>
              </UCard>
            </div>
          </div>

          <!-- Common Challenges -->
          <div>
            <h3 class="text-2xl font-bold mb-6">Common Verification Challenges</h3>
            <UCard>
              <div class="p-6">
                <div class="space-y-4">
                  <div class="flex items-start">
                    <UIcon name="i-heroicons-exclamation-triangle" class="w-6 h-6 text-amber-500 mr-3 mt-1 shrink-0" />
                    <div>
                      <h4 class="font-semibold mb-1">Ownership Documentation</h4>
                      <p class="text-gray-600 text-sm">Clearly documenting veteran ownership percentages and control mechanisms</p>
                    </div>
                  </div>
                  
                  <div class="flex items-start">
                    <UIcon name="i-heroicons-exclamation-triangle" class="w-6 h-6 text-amber-500 mr-3 mt-1 shrink-0" />
                    <div>
                      <h4 class="font-semibold mb-1">Management Control</h4>
                      <p class="text-gray-600 text-sm">Demonstrating veteran involvement in day-to-day operations and strategic decisions</p>
                    </div>
                  </div>
                  
                  <div class="flex items-start">
                    <UIcon name="i-heroicons-exclamation-triangle" class="w-6 h-6 text-amber-500 mr-3 mt-1 shrink-0" />
                    <div>
                      <h4 class="font-semibold mb-1">Size Standard Compliance</h4>
                      <p class="text-gray-600 text-sm">Ensuring the business meets small business size standards for its NAICS code</p>
                    </div>
                  </div>
                </div>
              </div>
            </UCard>
          </div>

          <!-- Next Steps -->
          <div class="bg-red-50 rounded-lg p-8">
            <h3 class="text-2xl font-bold text-red-900 mb-4 text-center">
              Ready to Get VOSB Verified?
            </h3>
            <p class="text-red-700 text-center mb-6">
              Our team of experts understands the unique challenges veterans face in business and can guide you through the verification process.
            </p>
            <div class="flex flex-wrap justify-center gap-4">
              <UButton color="primary" to="/contact">
                Schedule Consultation
              </UButton>
              <UButton variant="outline">
                Download VOSB Guide
              </UButton>
            </div>
          </div>
        </div>
      </div>
    </UPageSection>
  </div>
</template>

<script setup>
definePageMeta({
  title: 'VOSB Certification Guide',
  description: 'Complete guide to Veteran-Owned Small Business (VOSB) certification for federal contracting opportunities and veteran business programs.'
})
</script>