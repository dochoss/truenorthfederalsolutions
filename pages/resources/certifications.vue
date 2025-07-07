<template>
  <div>
    <Hero 
      title="Professional Certifications"
      subtitle="Industry-recognized certifications to advance your federal contracting career"
      background-class="bg-gradient-to-r from-amber-600 to-amber-800"
    />
    
    <BaseSection>
      <div class="max-w-6xl mx-auto">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Advance Your Career with Professional Certifications
          </h2>
          <p class="text-xl text-gray-600">
            Build expertise and credibility in federal contracting with industry-leading certification programs
          </p>
        </div>

        <!-- Featured Certification -->
        <BaseCard class="mb-12">
          <div class="p-8">
            <div class="flex items-center mb-4">
              <span class="bg-amber-100 text-amber-800 text-sm font-medium px-3 py-1 rounded-full">Featured Program</span>
              <span class="bg-green-100 text-green-800 text-sm font-medium px-3 py-1 rounded-full ml-2">Now Enrolling</span>
            </div>
            <h3 class="text-2xl font-bold mb-4">
              Certified Federal Proposal Professional (CFPP)
            </h3>
            <p class="text-gray-600 mb-6">
              Our flagship certification program covering all aspects of federal proposal development, from opportunity identification to contract award. This comprehensive program includes 40+ hours of instruction, hands-on exercises, and real-world case studies.
            </p>
            <div class="grid md:grid-cols-3 gap-4 mb-6">
              <div class="text-center">
                <div class="text-2xl font-bold text-amber-600">40+</div>
                <div class="text-sm text-gray-600">Hours of Instruction</div>
              </div>
              <div class="text-center">
                <div class="text-2xl font-bold text-amber-600">500+</div>
                <div class="text-sm text-gray-600">Professionals Certified</div>
              </div>
              <div class="text-center">
                <div class="text-2xl font-bold text-amber-600">95%</div>
                <div class="text-sm text-gray-600">Pass Rate</div>
              </div>
            </div>
            <div class="flex flex-wrap gap-4">
              <BaseButton variant="primary">
                Enroll Now - $2,495
              </BaseButton>
              <BaseButton variant="outline">
                View Curriculum
              </BaseButton>
            </div>
          </div>
        </BaseCard>

        <!-- Certification Categories -->
        <div class="grid md:grid-cols-3 gap-8 mb-12">
          <BaseCard class="text-center p-6">
            <Icon name="heroicons:academic-cap" class="w-12 h-12 text-amber-600 mb-4 mx-auto" />
            <h3 class="text-xl font-semibold mb-3">Professional Certifications</h3>
            <p class="text-gray-600 mb-4">Comprehensive programs for career advancement</p>
            <ul class="text-sm text-gray-600 space-y-1">
              <li>• 6-12 month programs</li>
              <li>• Industry recognition</li>
              <li>• Career advancement</li>
              <li>• Networking opportunities</li>
            </ul>
          </BaseCard>

          <BaseCard class="text-center p-6">
            <Icon name="heroicons:bolt" class="w-12 h-12 text-amber-600 mb-4 mx-auto" />
            <h3 class="text-xl font-semibold mb-3">Skill-Based Courses</h3>
            <p class="text-gray-600 mb-4">Focused training on specific competencies</p>
            <ul class="text-sm text-gray-600 space-y-1">
              <li>• 1-4 week courses</li>
              <li>• Targeted skills</li>
              <li>• Immediate application</li>
              <li>• Certificate of completion</li>
            </ul>
          </BaseCard>

          <BaseCard class="text-center p-6">
            <Icon name="heroicons:users" class="w-12 h-12 text-amber-600 mb-4 mx-auto" />
            <h3 class="text-xl font-semibold mb-3">Corporate Training</h3>
            <p class="text-gray-600 mb-4">Custom programs for teams and organizations</p>
            <ul class="text-sm text-gray-600 space-y-1">
              <li>• Customized content</li>
              <li>• On-site or virtual</li>
              <li>• Team certification</li>
              <li>• Ongoing support</li>
            </ul>
          </BaseCard>
        </div>

        <!-- Available Certifications -->
        <div class="space-y-8">
          <!-- Professional Certifications -->
          <div>
            <h3 class="text-2xl font-bold mb-6 flex items-center">
              <Icon name="heroicons:star" class="w-8 h-8 text-amber-600 mr-3" />
              Professional Certifications
            </h3>
            <div class="grid md:grid-cols-2 gap-6">
              <BaseCard>
                <div class="p-6">
                  <div class="flex items-center justify-between mb-4">
                    <h4 class="text-lg font-semibold">Certified Federal Proposal Professional (CFPP)</h4>
                    <span class="bg-green-100 text-green-800 text-xs font-medium px-2 py-1 rounded">Available</span>
                  </div>
                  <p class="text-gray-600 mb-4">
                    Master all aspects of federal proposal development, from market research to contract award.
                  </p>
                  <div class="text-sm text-gray-500 mb-4">
                    Duration: 6 months | Format: Online + Virtual Labs | Investment: $2,495
                  </div>
                  <BaseButton variant="outline" size="sm" class="mr-2">Learn More</BaseButton>
                  <BaseButton variant="primary" size="sm">Enroll Now</BaseButton>
                </div>
              </BaseCard>

              <BaseCard>
                <div class="p-6">
                  <div class="flex items-center justify-between mb-4">
                    <h4 class="text-lg font-semibold">Federal Compliance Specialist (FCS)</h4>
                    <span class="bg-blue-100 text-blue-800 text-xs font-medium px-2 py-1 rounded">Starting Q2 2025</span>
                  </div>
                  <p class="text-gray-600 mb-4">
                    Become an expert in federal regulations, compliance requirements, and risk management.
                  </p>
                  <div class="text-sm text-gray-500 mb-4">
                    Duration: 4 months | Format: Hybrid | Investment: $1,995
                  </div>
                  <BaseButton variant="outline" size="sm" class="mr-2">Join Waitlist</BaseButton>
                  <BaseButton variant="outline" size="sm">Learn More</BaseButton>
                </div>
              </BaseCard>

              <BaseCard>
                <div class="p-6">
                  <div class="flex items-center justify-between mb-4">
                    <h4 class="text-lg font-semibold">Government Contracts Manager (GCM)</h4>
                    <span class="bg-amber-100 text-amber-800 text-xs font-medium px-2 py-1 rounded">Development</span>
                  </div>
                  <p class="text-gray-600 mb-4">
                    Advanced certification for contract management, administration, and performance optimization.
                  </p>
                  <div class="text-sm text-gray-500 mb-4">
                    Duration: 8 months | Format: Executive Program | Investment: $3,995
                  </div>
                  <BaseButton variant="outline" size="sm" class="mr-2">Express Interest</BaseButton>
                  <BaseButton variant="outline" size="sm">Learn More</BaseButton>
                </div>
              </BaseCard>

              <BaseCard>
                <div class="p-6">
                  <div class="flex items-center justify-between mb-4">
                    <h4 class="text-lg font-semibold">Federal Business Developer (FBD)</h4>
                    <span class="bg-green-100 text-green-800 text-xs font-medium px-2 py-1 rounded">Available</span>
                  </div>
                  <p class="text-gray-600 mb-4">
                    Strategic business development for federal markets, including capture management and teaming.
                  </p>
                  <div class="text-sm text-gray-500 mb-4">
                    Duration: 5 months | Format: Virtual Cohort | Investment: $2,195
                  </div>
                  <BaseButton variant="outline" size="sm" class="mr-2">Learn More</BaseButton>
                  <BaseButton variant="primary" size="sm">Enroll Now</BaseButton>
                </div>
              </BaseCard>
            </div>
          </div>

          <!-- Skill-Based Courses -->
          <div>
            <h3 class="text-2xl font-bold mb-6 flex items-center">
              <Icon name="heroicons:lightning-bolt" class="w-8 h-8 text-amber-600 mr-3" />
              Skill-Based Courses
            </h3>
            <div class="grid md:grid-cols-3 gap-6">
              <BaseCard>
                <div class="p-6">
                  <h4 class="text-lg font-semibold mb-3">RFP Analysis Mastery</h4>
                  <p class="text-gray-600 mb-4">Learn to decode complex RFPs and identify winning strategies.</p>
                  <div class="text-sm text-gray-500 mb-4">2 weeks | $495</div>
                  <BaseButton variant="outline" size="sm">Enroll</BaseButton>
                </div>
              </BaseCard>

              <BaseCard>
                <div class="p-6">
                  <h4 class="text-lg font-semibold mb-3">Technical Writing for Proposals</h4>
                  <p class="text-gray-600 mb-4">Master the art of clear, compelling technical communication.</p>
                  <div class="text-sm text-gray-500 mb-4">3 weeks | $695</div>
                  <BaseButton variant="outline" size="sm">Enroll</BaseButton>
                </div>
              </BaseCard>

              <BaseCard>
                <div class="p-6">
                  <h4 class="text-lg font-semibold mb-3">Cost Proposal Development</h4>
                  <p class="text-gray-600 mb-4">Build accurate, competitive cost proposals that win contracts.</p>
                  <div class="text-sm text-gray-500 mb-4">4 weeks | $895</div>
                  <BaseButton variant="outline" size="sm">Enroll</BaseButton>
                </div>
              </BaseCard>

              <BaseCard>
                <div class="p-6">
                  <h4 class="text-lg font-semibold mb-3">Past Performance Storytelling</h4>
                  <p class="text-gray-600 mb-4">Craft compelling narratives that demonstrate your capabilities.</p>
                  <div class="text-sm text-gray-500 mb-4">2 weeks | $495</div>
                  <BaseButton variant="outline" size="sm">Enroll</BaseButton>
                </div>
              </BaseCard>

              <BaseCard>
                <div class="p-6">
                  <h4 class="text-lg font-semibold mb-3">Federal Market Research</h4>
                  <p class="text-gray-600 mb-4">Identify opportunities and understand your competitive landscape.</p>
                  <div class="text-sm text-gray-500 mb-4">3 weeks | $695</div>
                  <BaseButton variant="outline" size="sm">Enroll</BaseButton>
                </div>
              </BaseCard>

              <BaseCard>
                <div class="p-6">
                  <h4 class="text-lg font-semibold mb-3">Bid/No-Bid Decision Making</h4>
                  <p class="text-gray-600 mb-4">Make strategic decisions about which opportunities to pursue.</p>
                  <div class="text-sm text-gray-500 mb-4">1 week | $395</div>
                  <BaseButton variant="outline" size="sm">Enroll</BaseButton>
                </div>
              </BaseCard>
            </div>
          </div>
        </div>

        <!-- Benefits of Certification -->
        <div class="bg-amber-50 rounded-lg p-8 mt-12">
          <h3 class="text-2xl font-bold text-amber-900 mb-6 text-center">
            Why Get Certified?
          </h3>
          <div class="grid md:grid-cols-2 lg:grid-cols-4 gap-6">
            <div class="text-center">
              <Icon name="heroicons:arrow-trending-up" class="w-12 h-12 text-amber-600 mb-3 mx-auto" />
              <h4 class="font-semibold text-amber-900 mb-2">Career Advancement</h4>
              <p class="text-amber-700 text-sm">Stand out in a competitive job market</p>
            </div>
            <div class="text-center">
              <Icon name="heroicons:currency-dollar" class="w-12 h-12 text-amber-600 mb-3 mx-auto" />
              <h4 class="font-semibold text-amber-900 mb-2">Higher Earning Potential</h4>
              <p class="text-amber-700 text-sm">Certified professionals earn 20% more on average</p>
            </div>
            <div class="text-center">
              <Icon name="heroicons:shield-check" class="w-12 h-12 text-amber-600 mb-3 mx-auto" />
              <h4 class="font-semibold text-amber-900 mb-2">Industry Recognition</h4>
              <p class="text-amber-700 text-sm">Gain credibility with clients and employers</p>
            </div>
            <div class="text-center">
              <Icon name="heroicons:users" class="w-12 h-12 text-amber-600 mb-3 mx-auto" />
              <h4 class="font-semibold text-amber-900 mb-2">Professional Network</h4>
              <p class="text-amber-700 text-sm">Connect with like-minded professionals</p>
            </div>
          </div>
        </div>

        <!-- Call to Action -->
        <div class="text-center mt-12">
          <h3 class="text-2xl font-bold mb-4">Ready to Advance Your Career?</h3>
          <p class="text-xl text-gray-600 mb-8">
            Join hundreds of professionals who have accelerated their careers with our certification programs
          </p>
          <div class="flex flex-wrap justify-center gap-4">
            <BaseButton variant="primary" size="lg">
              <NuxtLink to="/contact">Schedule Consultation</NuxtLink>
            </BaseButton>
            <BaseButton variant="outline" size="lg">
              Download Program Catalog
            </BaseButton>
          </div>
        </div>
      </div>
    </BaseSection>
  </div>
</template>

<script setup>
definePageMeta({
  title: 'Professional Certifications',
  description: 'Industry-recognized certifications to advance your federal contracting career and expertise.'
})
</script>
