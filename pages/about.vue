<template>
  <div>
    <!-- About Hero -->
    <section class="bg-white py-24">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center">
          <Icon name="heroicons:user-circle" class="w-16 h-16 text-blue-600 mx-auto mb-8" />
          <h1 class="text-4xl font-bold text-gray-900 mb-6">
            About True North Federal Solutions
          </h1>
          <p class="text-xl text-gray-600 leading-relaxed">
            At True North Federal Solutions, our mission is to demystify federal contracting
            for small businesses. Led by a former federal Contracting Officer with over 15
            years of experience, we equip you with the tools, strategies, and insights needed
            to become contract-ready, submit competitive proposals, and grow in the public
            sector.
          </p>
        </div>
      </div>
    </section>

    <!-- Meet the Founder -->
    <section class="py-16 bg-gray-50">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        <h2 class="text-3xl font-bold text-gray-900 text-center mb-12">
          Meet the Founder
        </h2>
        
        <div class="bg-white rounded-lg p-8 shadow-sm mb-8">
          <div class="text-center mb-6">
            <h3 class="text-2xl font-bold text-gray-900 mb-2">Jennifer Peterson</h3>
            <p class="text-lg text-blue-600 font-semibold mb-2">Founder & Principal Consultant | True North Federal Solutions</p>
            <p class="text-md text-gray-700 italic">From the Inside Out: Experience. Integrity. Results.</p>
          </div>
          
          <div class="space-y-6 text-gray-600">
            <p>
              Jennifer Peterson is a highly accomplished federal acquisition expert with over 15 years
              of experience spanning multiple U.S. government agencies. As the Founder and Principal
              Consultant of True North Federal Solutions, Jennifer brings unmatched insight into the
              federal procurement landscape—earned from years of managing and negotiating
              contracts valued in the hundreds of millions of dollars.
            </p>
            
            <p>
              Her federal contracting journey began with the Defense Contract Management Agency
              (DCMA) and advanced through roles with the Red River Army Depot, U.S. Army Corps
              of Engineers (USACE), NASA's Johnson Space Center, and the U.S. Department of
              Agriculture (USDA). She has held key leadership roles, including Supervisory Contract
              Specialist and Contracting Officer with an active $75 million warrant, overseeing
              complex acquisition portfolios and mentoring junior specialists.
            </p>
            
            <p>
              Jennifer has managed full life-cycle acquisition strategies—from pre-award planning and
              cost analysis to post-award administration and contract closeout—across a wide range of
              contract types including FFP, IDIQ, CPAF, and CPIF. During her tenure at NASA, she
              served as Lead Contract Specialist for the $21B NAS15-1000 contract supporting the
              International Space Station, where her negotiation leadership saved the government over
              $16M.
            </p>
            
            <p>
              Throughout her career, Jennifer has been recognized for her strategic mindset, process
              improvement leadership, and commitment to acquisition excellence. She has conducted
              over 130 peer reviews and closed more than 280 contracts in under six months, ensuring
              compliance, speed, and accuracy for federal missions.
            </p>
            
            <p>
              Jennifer holds a Bachelor of Science in Business Administration with a concentration in
              Human Resource Management and maintains both the FAC-C Professional Certification
              and DAWIA Level III certification.
            </p>
            
            <p>
              At True North Federal Solutions, Jennifer's mission is to help small and growing
              businesses navigate the federal contracting world with clarity and confidence. Her
              philosophy is simple: "I've sat at the government table—now I help you win from the
              other side." With deep knowledge of the FAR, contracting strategy, and procurement
              systems, she offers practical, compliance-driven support that empowers clients to
              compete—and succeed—in government markets.
            </p>
          </div>
        </div>
      </div>
    </section>



    <!-- Call to Action -->
    <section class="py-16 bg-blue-50">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <Icon name="heroicons:phone" class="w-16 h-16 text-blue-600 mx-auto mb-6" />
        <h2 class="text-3xl font-bold text-gray-900 mb-4">
          Ready to Start Your Federal Contracting Journey?
        </h2>
        <p class="text-lg text-gray-600 mb-8">
          Schedule a consultation to discuss your business goals and learn how we can help you succeed in federal contracting.
        </p>
        
        <div class="bg-white rounded-lg p-6 shadow-sm inline-block">
          <div class="text-left">
            <p class="text-sm text-gray-600 mb-2">Get started with a free consultation:</p>
            <div class="space-y-2">
              <p class="text-sm text-gray-700">✓ Assess your federal contracting readiness</p>
              <p class="text-sm text-gray-700">✓ Understand certification opportunities</p>
              <p class="text-sm text-gray-700">✓ Develop a strategic roadmap for success</p>
            </div>
            <div class="mt-6">
              <a href="/contact" class="bg-blue-600 text-white px-6 py-3 rounded-md hover:bg-blue-700 transition-colors font-medium inline-block">
                Schedule Your Consultation
              </a>
            </div>
          </div>
        </div>
      </div>
    </section>
  </div>
</template>

<script setup>
// Set page meta
definePageMeta({
  title: 'About - True North Federal Solutions'
})

// Set head for SEO
useHead({
  title: 'About Us - True North Federal Solutions',
  meta: [
    { 
      name: 'description', 
      content: 'Learn about True North Federal Solutions and our founder\'s 15+ years of federal contracting experience. Expert guidance for small businesses entering federal contracting.' 
    },
    {
      name: 'keywords',
      content: 'federal contracting expert, contracting officer consultant, small business federal contracts, WOSB, VOSB, federal acquisition specialist'
    }
  ]
})
</script>
